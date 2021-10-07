using Microsoft.ML;
using System;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace MachineLearningClassify
{
    public class Classify
    {
        public string _trainDataPath { get; set; }
        public string _testDataPath { get; set; }
        public string _modelPath { get; set; }

        private static MLContext _mlContext;
        private static PredictionEngine<DataElement, DocTypePrediction> _predEngine;
        public static ITransformer _trainedModel;
        static IDataView _trainingDataView;
        public string[] BuildTrainAndEvaluateModel()
        {
            string[] result = new string[2];
            // Create object of  MLContext
            _mlContext = new MLContext(seed: 0);
            // Load Training Data
            _trainingDataView = _mlContext.Data.LoadFromTextFile<DataElement>(_trainDataPath, hasHeader: true);
            var pipeline = ProcessData();
            var trainingPipeline = BuildAndTrainModel(_trainingDataView, pipeline);
            try
            {
                double accuracy = Evaluate(_trainingDataView.Schema);
                result[0] = "Success";
                result[1] = String.Format("{0:0.###}", accuracy*100);
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message.ToString());
                result[0] = "Failed";
                result[1] = "0";
            }
            
            return result;
        }
        public static IEstimator<ITransformer> ProcessData()
        {
            // We need to create the pipe line and define the work flows in it
            // Choose the algorithm
            var pipeline = _mlContext.Transforms.Conversion.MapValueToKey(inputColumnName: "DocType", outputColumnName: "Label")
                .Append(_mlContext.Transforms.Text.FeaturizeText(inputColumnName: "TextData", outputColumnName: "TextDataFeaturized"))
                .Append(_mlContext.Transforms.Concatenate("Features", "TextDataFeaturized")).AppendCacheCheckpoint(_mlContext);
            return pipeline;
        }
        public static IEstimator<ITransformer> BuildAndTrainModel(IDataView trainingDataView, IEstimator<ITransformer> pipeline)
        {
            var trainingPipeline = pipeline.Append(_mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
                                    .Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));
            //Training the algorithm and we want the model out
            _trainedModel = trainingPipeline.Fit(trainingDataView);
            // Create a prediction engine from the model for feeding new data.
            _predEngine = _mlContext.Model.CreatePredictionEngine<DataElement, DocTypePrediction>(_trainedModel);
            return trainingPipeline;
        }
        public double Evaluate(DataViewSchema trainingDataViewSchema)
        {
            var testDataView = _mlContext.Data.LoadFromTextFile<DataElement>(_testDataPath, hasHeader: true);
            var testMetrics = _mlContext.MulticlassClassification.Evaluate(_trainedModel.Transform(testDataView));
             
            Console.WriteLine($"*************************************************************************************************************");
            Console.WriteLine($"*       Metrics for Multi-class Classification model - Test Data     ");
            Console.WriteLine($"*------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"*       MicroAccuracy:    {testMetrics.MicroAccuracy:0.###}");
            Console.WriteLine($"*       MacroAccuracy:    {testMetrics.MacroAccuracy:0.###}");
            Console.WriteLine($"*       LogLoss:          {testMetrics.LogLoss:#.###}");
            Console.WriteLine($"*       LogLossReduction: {testMetrics.LogLossReduction:#.###}");
            Console.WriteLine($"*************************************************************************************************************");
            // Save the model
            SaveModelAsFile(_mlContext, trainingDataViewSchema, _trainedModel);
            return testMetrics.MicroAccuracy;
        }
        private  void SaveModelAsFile(MLContext mlContext, DataViewSchema trainingDataViewSchema, ITransformer model)
        {
            mlContext.Model.Save(model, trainingDataViewSchema, _modelPath);
        }
        public DocTypePrediction PredictDocType(string InputData, string _modelPath)
        {
            // Use the model 
            _mlContext = new MLContext(seed: 0);
            // Load the model
            ITransformer loadedModel = _mlContext.Model.Load(_modelPath, out var modelInputSchema);
            DataElement dt = new DataElement() { TextData = InputData };
            // Create predict engine
            _predEngine = _mlContext.Model.CreatePredictionEngine<DataElement, DocTypePrediction>(loadedModel);
            // Get the result from prediction
            var prediction = _predEngine.Predict(dt);
           // Console.WriteLine($"=============== Single Prediction - Result: {prediction.DocType} ===============");
            return prediction;
        }

    }
    
}
