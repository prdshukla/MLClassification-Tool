using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MachineLearningClassify
{
    public partial class MLClassifierUI : Form
    {
        public string TrainFileLocation;
        public string TestFileLocation;
        public string ModelLocation;
        public MLClassifierUI()
        {
            InitializeComponent();
            this.KeyPreview = true;
            txtBuildStatus.Text = "";
            txtAbout.Text += "This program used ML.net library to classify raw text" + Environment.NewLine;
            txtAbout.Text += "" + Environment.NewLine;
            txtAbout.Text += "Build Model -" + Environment.NewLine;
            txtAbout.Text += "" + Environment.NewLine;
            txtAbout.Text += "Train Data Location -Location of tsv file for train data" + Environment.NewLine;
            txtAbout.Text += "Test Data Location - Location of tsv file for test data" + Environment.NewLine;
            txtAbout.Text += "Save Model Location - Folder location to save the model.This program doesn't have dynamic model name but it can be achived using small code change" + Environment.NewLine;
            txtAbout.Text += "Build Model Button - This button is used to build the model and evalulate the the model using test data. In order to build the model, program would need Test and Train data tsv files and the location where model should be saved" + Environment.NewLine;
            txtAbout.Text += "Model Build Status - This text box is updated as soon as Build model button is clicked.[Possible Status values - Started, Inprogress, Failed, Success]" + Environment.NewLine;
            txtAbout.Text += "" + Environment.NewLine;
            txtAbout.Text += "Get Doc Type" + Environment.NewLine;
            txtAbout.Text += "" + Environment.NewLine;
            txtAbout.Text += "Text to Classify - multi line text box which is used for input raw text needing classification" + Environment.NewLine;
            txtAbout.Text += "Select Model - location for <modelname>.zip" + Environment.NewLine;
            txtAbout.Text += "Document Type - return response from model" + Environment.NewLine;
            txtAbout.Text += "Confidence - highest score for predection";
        }
        private void btnBrowseTrainDtLocal_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileTrainData.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                TrainFileLocation = openFileTrainData.FileName;
                txtBoxTrainData.Text = TrainFileLocation;
            }
        }
        private void btnBrowseTestDtLocal_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileTestData.ShowDialog();
            if (result == DialogResult.OK)
            {
                TestFileLocation = openFileTestData.FileName;
                txtBoxTestData.Text = TestFileLocation;
            }
        }

        private void btnBuildModel_Click(object sender, EventArgs e)
        {
            txtBuildStatus.Text = "Started";
            Classify MLC = new Classify()
            {
                _trainDataPath = txtBoxTrainData.Text,
                _testDataPath = txtBoxTestData.Text,
                // TBD to for dynamic
                _modelPath = txtSaveModelLocation.Text + @"\Model.zip"
            };
            if (!string.IsNullOrEmpty(txtBoxTrainData.Text) && !string.IsNullOrEmpty(txtBoxTestData.Text))
            {
                txtBuildStatus.Text = "Inprogress";
                string[] result = MLC.BuildTrainAndEvaluateModel();
                txtBuildStatus.Text = result[0];
                txtModelAccuracy.Text = result[1];
            }
            else
            {
                MessageBox.Show("Please select Train and Test Data file");
            }
        }

        private void btnSBrowseModelFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = openFolderModelLocation.ShowDialog();
            if (result == DialogResult.OK)
            {
                ModelLocation = openFolderModelLocation.SelectedPath;
                txtSaveModelLocation.Text = ModelLocation;
            }
        }

        private void btnGetDoctype_Click(object sender, EventArgs e)
        {
            Classify MLC = new Classify();
            if (!string.IsNullOrEmpty(txtInputData.Text) && !string.IsNullOrEmpty(txtSelectedModel.Text))
            {
                DocTypePrediction predictionResult = MLC.PredictDocType(txtInputData.Text, txtSelectedModel.Text); // Pass text and get result
                txtDocType.Text = predictionResult.DocType;
                txtConfidence.Text = Convert.ToString(predictionResult.Score.Max() * 100);
            }
            else
            {
                MessageBox.Show("Please input text data and select the model ");
            }
        }

        private void btnSelectModel_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileModel.ShowDialog();
            if (result == DialogResult.OK)
            {
                ModelLocation = openFileModel.FileName;
                txtSelectedModel.Text = ModelLocation;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInputData.Text = "";
            // txtSelectedModel.Text = ""; we are going to use same model. Let's not clear out
            txtConfidence.Text = "";
            txtDocType.Text = "";
        }

        private void btnResetBuildModelPage_Click(object sender, EventArgs e)
        {
            txtBoxTestData.Text = "";
            txtBoxTrainData.Text = "";
            txtBuildStatus.Text = "";
            txtSaveModelLocation.Text = "";
            txtModelAccuracy.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/harish-mehta/");
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.Alt && e.KeyCode == Keys.G)
            {
                tabControl1.SelectedIndex = 0;
            }
            if (e.Alt && e.KeyCode == Keys.B)
            {
                tabControl1.SelectedIndex = 1;
            }
            if (e.Alt && e.KeyCode == Keys.A)
            {
                tabControl1.SelectedIndex = 2;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
