using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
namespace MachineLearningClassify
{
    class DataElement
    {
        [LoadColumn(0)]
        public string DocType { get; set; }
        [LoadColumn(1)]
        public string TextData { get; set; }
 

    }

        public class DocTypePrediction
        {
        [ColumnName("PredictedLabel")]
        public string DocType { get; set; }
        public float[] Score { get; set; }
    }
    
}
