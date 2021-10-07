namespace MachineLearningClassify
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtInputData = new System.Windows.Forms.TextBox();
            this.lblOcrData = new System.Windows.Forms.Label();
            this.lblDoctype = new System.Windows.Forms.Label();
            this.txtDocType = new System.Windows.Forms.TextBox();
            this.lblConfidence = new System.Windows.Forms.Label();
            this.txtConfidence = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabgetDocType = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectedModel = new System.Windows.Forms.TextBox();
            this.btnSelectModel = new System.Windows.Forms.Button();
            this.lblModelPath = new System.Windows.Forms.Label();
            this.btnGetDoctype = new System.Windows.Forms.Button();
            this.btnResetGetDocTypePage = new System.Windows.Forms.Button();
            this.tabBuildModel = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelAccuracy = new System.Windows.Forms.TextBox();
            this.lblModelAccuracy = new System.Windows.Forms.Label();
            this.btnResetBuildModelPage = new System.Windows.Forms.Button();
            this.txtSaveModelLocation = new System.Windows.Forms.TextBox();
            this.btnSBrowseModelFolder = new System.Windows.Forms.Button();
            this.lblModelStorePath = new System.Windows.Forms.Label();
            this.txtBoxTestData = new System.Windows.Forms.TextBox();
            this.txtBoxTrainData = new System.Windows.Forms.TextBox();
            this.btnBrowseTestDtLocal = new System.Windows.Forms.Button();
            this.btnBrowseTrainDtLocal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuildStatus = new System.Windows.Forms.TextBox();
            this.btnBuildModel = new System.Windows.Forms.Button();
            this.LblTestDataLocation = new System.Windows.Forms.Label();
            this.lblTrainDataLocation = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAbout = new System.Windows.Forms.TextBox();
            this.openFileTrainData = new System.Windows.Forms.OpenFileDialog();
            this.openFileTestData = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFolderModelLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileModel = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabgetDocType.SuspendLayout();
            this.tabBuildModel.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputData
            // 
            this.txtInputData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInputData.Location = new System.Drawing.Point(37, 74);
            this.txtInputData.Multiline = true;
            this.txtInputData.Name = "txtInputData";
            this.txtInputData.Size = new System.Drawing.Size(634, 135);
            this.txtInputData.TabIndex = 2;
            // 
            // lblOcrData
            // 
            this.lblOcrData.AutoSize = true;
            this.lblOcrData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcrData.Location = new System.Drawing.Point(33, 52);
            this.lblOcrData.Name = "lblOcrData";
            this.lblOcrData.Size = new System.Drawing.Size(111, 18);
            this.lblOcrData.TabIndex = 3;
            this.lblOcrData.Text = "Text to Classify";
            // 
            // lblDoctype
            // 
            this.lblDoctype.AutoSize = true;
            this.lblDoctype.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDoctype.Location = new System.Drawing.Point(217, 291);
            this.lblDoctype.Name = "lblDoctype";
            this.lblDoctype.Size = new System.Drawing.Size(102, 18);
            this.lblDoctype.TabIndex = 4;
            this.lblDoctype.Text = "Classification";
            // 
            // txtDocType
            // 
            this.txtDocType.Enabled = false;
            this.txtDocType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocType.Location = new System.Drawing.Point(325, 289);
            this.txtDocType.Name = "txtDocType";
            this.txtDocType.Size = new System.Drawing.Size(100, 20);
            this.txtDocType.TabIndex = 5;
            // 
            // lblConfidence
            // 
            this.lblConfidence.AutoSize = true;
            this.lblConfidence.Font = new System.Drawing.Font("Arial", 12F);
            this.lblConfidence.Location = new System.Drawing.Point(475, 291);
            this.lblConfidence.Name = "lblConfidence";
            this.lblConfidence.Size = new System.Drawing.Size(88, 18);
            this.lblConfidence.TabIndex = 6;
            this.lblConfidence.Text = "Confidence";
            // 
            // txtConfidence
            // 
            this.txtConfidence.Enabled = false;
            this.txtConfidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfidence.Location = new System.Drawing.Point(569, 289);
            this.txtConfidence.Name = "txtConfidence";
            this.txtConfidence.Size = new System.Drawing.Size(100, 20);
            this.txtConfidence.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabgetDocType);
            this.tabControl1.Controls.Add(this.tabBuildModel);
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 8;
            // 
            // tabgetDocType
            // 
            this.tabgetDocType.Controls.Add(this.label2);
            this.tabgetDocType.Controls.Add(this.txtSelectedModel);
            this.tabgetDocType.Controls.Add(this.btnSelectModel);
            this.tabgetDocType.Controls.Add(this.lblModelPath);
            this.tabgetDocType.Controls.Add(this.btnGetDoctype);
            this.tabgetDocType.Controls.Add(this.btnResetGetDocTypePage);
            this.tabgetDocType.Controls.Add(this.txtInputData);
            this.tabgetDocType.Controls.Add(this.txtConfidence);
            this.tabgetDocType.Controls.Add(this.lblConfidence);
            this.tabgetDocType.Controls.Add(this.lblOcrData);
            this.tabgetDocType.Controls.Add(this.txtDocType);
            this.tabgetDocType.Controls.Add(this.lblDoctype);
            this.tabgetDocType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabgetDocType.Location = new System.Drawing.Point(4, 22);
            this.tabgetDocType.Name = "tabgetDocType";
            this.tabgetDocType.Padding = new System.Windows.Forms.Padding(3);
            this.tabgetDocType.Size = new System.Drawing.Size(768, 400);
            this.tabgetDocType.TabIndex = 0;
            this.tabgetDocType.Text = "Test Model";
            this.tabgetDocType.ToolTipText = "Alt+G";
            this.tabgetDocType.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Validate";
            // 
            // txtSelectedModel
            // 
            this.txtSelectedModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSelectedModel.Location = new System.Drawing.Point(291, 222);
            this.txtSelectedModel.Multiline = true;
            this.txtSelectedModel.Name = "txtSelectedModel";
            this.txtSelectedModel.Size = new System.Drawing.Size(378, 44);
            this.txtSelectedModel.TabIndex = 12;
            // 
            // btnSelectModel
            // 
            this.btnSelectModel.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSelectModel.Location = new System.Drawing.Point(159, 224);
            this.btnSelectModel.Name = "btnSelectModel";
            this.btnSelectModel.Size = new System.Drawing.Size(99, 34);
            this.btnSelectModel.TabIndex = 11;
            this.btnSelectModel.Text = "Browse";
            this.btnSelectModel.UseVisualStyleBackColor = true;
            this.btnSelectModel.Click += new System.EventHandler(this.btnSelectModel_Click);
            // 
            // lblModelPath
            // 
            this.lblModelPath.AutoSize = true;
            this.lblModelPath.Font = new System.Drawing.Font("Arial", 12F);
            this.lblModelPath.Location = new System.Drawing.Point(37, 232);
            this.lblModelPath.Name = "lblModelPath";
            this.lblModelPath.Size = new System.Drawing.Size(99, 18);
            this.lblModelPath.TabIndex = 10;
            this.lblModelPath.Text = "Select Model";
            // 
            // btnGetDoctype
            // 
            this.btnGetDoctype.Font = new System.Drawing.Font("Arial", 12F);
            this.btnGetDoctype.Location = new System.Drawing.Point(51, 281);
            this.btnGetDoctype.Name = "btnGetDoctype";
            this.btnGetDoctype.Size = new System.Drawing.Size(101, 35);
            this.btnGetDoctype.TabIndex = 9;
            this.btnGetDoctype.Text = "Classify";
            this.btnGetDoctype.UseVisualStyleBackColor = true;
            this.btnGetDoctype.Click += new System.EventHandler(this.btnGetDoctype_Click);
            // 
            // btnResetGetDocTypePage
            // 
            this.btnResetGetDocTypePage.Font = new System.Drawing.Font("Arial", 12F);
            this.btnResetGetDocTypePage.Location = new System.Drawing.Point(325, 349);
            this.btnResetGetDocTypePage.Name = "btnResetGetDocTypePage";
            this.btnResetGetDocTypePage.Size = new System.Drawing.Size(75, 28);
            this.btnResetGetDocTypePage.TabIndex = 8;
            this.btnResetGetDocTypePage.Text = "Reset";
            this.btnResetGetDocTypePage.UseVisualStyleBackColor = true;
            this.btnResetGetDocTypePage.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabBuildModel
            // 
            this.tabBuildModel.Controls.Add(this.label1);
            this.tabBuildModel.Controls.Add(this.txtModelAccuracy);
            this.tabBuildModel.Controls.Add(this.lblModelAccuracy);
            this.tabBuildModel.Controls.Add(this.btnResetBuildModelPage);
            this.tabBuildModel.Controls.Add(this.txtSaveModelLocation);
            this.tabBuildModel.Controls.Add(this.btnSBrowseModelFolder);
            this.tabBuildModel.Controls.Add(this.lblModelStorePath);
            this.tabBuildModel.Controls.Add(this.txtBoxTestData);
            this.tabBuildModel.Controls.Add(this.txtBoxTrainData);
            this.tabBuildModel.Controls.Add(this.btnBrowseTestDtLocal);
            this.tabBuildModel.Controls.Add(this.btnBrowseTrainDtLocal);
            this.tabBuildModel.Controls.Add(this.label6);
            this.tabBuildModel.Controls.Add(this.txtBuildStatus);
            this.tabBuildModel.Controls.Add(this.btnBuildModel);
            this.tabBuildModel.Controls.Add(this.LblTestDataLocation);
            this.tabBuildModel.Controls.Add(this.lblTrainDataLocation);
            this.tabBuildModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBuildModel.Location = new System.Drawing.Point(4, 22);
            this.tabBuildModel.Name = "tabBuildModel";
            this.tabBuildModel.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuildModel.Size = new System.Drawing.Size(768, 400);
            this.tabBuildModel.TabIndex = 1;
            this.tabBuildModel.Text = "Build Model";
            this.tabBuildModel.ToolTipText = "Alt+B";
            this.tabBuildModel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Build";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtModelAccuracy
            // 
            this.txtModelAccuracy.Enabled = false;
            this.txtModelAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtModelAccuracy.Location = new System.Drawing.Point(437, 290);
            this.txtModelAccuracy.Name = "txtModelAccuracy";
            this.txtModelAccuracy.Size = new System.Drawing.Size(91, 23);
            this.txtModelAccuracy.TabIndex = 16;
            // 
            // lblModelAccuracy
            // 
            this.lblModelAccuracy.AutoSize = true;
            this.lblModelAccuracy.Font = new System.Drawing.Font("Arial", 12F);
            this.lblModelAccuracy.Location = new System.Drawing.Point(303, 289);
            this.lblModelAccuracy.Name = "lblModelAccuracy";
            this.lblModelAccuracy.Size = new System.Drawing.Size(118, 18);
            this.lblModelAccuracy.TabIndex = 15;
            this.lblModelAccuracy.Text = "Model Accuracy";
            // 
            // btnResetBuildModelPage
            // 
            this.btnResetBuildModelPage.Font = new System.Drawing.Font("Arial", 10F);
            this.btnResetBuildModelPage.Location = new System.Drawing.Point(340, 345);
            this.btnResetBuildModelPage.Name = "btnResetBuildModelPage";
            this.btnResetBuildModelPage.Size = new System.Drawing.Size(75, 27);
            this.btnResetBuildModelPage.TabIndex = 14;
            this.btnResetBuildModelPage.Text = "Reset";
            this.btnResetBuildModelPage.UseVisualStyleBackColor = true;
            this.btnResetBuildModelPage.Click += new System.EventHandler(this.btnResetBuildModelPage_Click);
            // 
            // txtSaveModelLocation
            // 
            this.txtSaveModelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSaveModelLocation.Location = new System.Drawing.Point(318, 219);
            this.txtSaveModelLocation.Multiline = true;
            this.txtSaveModelLocation.Name = "txtSaveModelLocation";
            this.txtSaveModelLocation.Size = new System.Drawing.Size(342, 44);
            this.txtSaveModelLocation.TabIndex = 13;
            // 
            // btnSBrowseModelFolder
            // 
            this.btnSBrowseModelFolder.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSBrowseModelFolder.Location = new System.Drawing.Point(222, 220);
            this.btnSBrowseModelFolder.Name = "btnSBrowseModelFolder";
            this.btnSBrowseModelFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSBrowseModelFolder.TabIndex = 12;
            this.btnSBrowseModelFolder.Text = "Browse";
            this.btnSBrowseModelFolder.UseVisualStyleBackColor = true;
            this.btnSBrowseModelFolder.Click += new System.EventHandler(this.btnSBrowseModelFolder_Click);
            // 
            // lblModelStorePath
            // 
            this.lblModelStorePath.AutoSize = true;
            this.lblModelStorePath.Font = new System.Drawing.Font("Arial", 12F);
            this.lblModelStorePath.Location = new System.Drawing.Point(42, 220);
            this.lblModelStorePath.Name = "lblModelStorePath";
            this.lblModelStorePath.Size = new System.Drawing.Size(155, 18);
            this.lblModelStorePath.TabIndex = 11;
            this.lblModelStorePath.Text = "Save Model Location";
            // 
            // txtBoxTestData
            // 
            this.txtBoxTestData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxTestData.Location = new System.Drawing.Point(318, 137);
            this.txtBoxTestData.Multiline = true;
            this.txtBoxTestData.Name = "txtBoxTestData";
            this.txtBoxTestData.Size = new System.Drawing.Size(342, 41);
            this.txtBoxTestData.TabIndex = 9;
            // 
            // txtBoxTrainData
            // 
            this.txtBoxTrainData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxTrainData.Location = new System.Drawing.Point(318, 60);
            this.txtBoxTrainData.Multiline = true;
            this.txtBoxTrainData.Name = "txtBoxTrainData";
            this.txtBoxTrainData.Size = new System.Drawing.Size(342, 40);
            this.txtBoxTrainData.TabIndex = 8;
            // 
            // btnBrowseTestDtLocal
            // 
            this.btnBrowseTestDtLocal.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBrowseTestDtLocal.Location = new System.Drawing.Point(222, 136);
            this.btnBrowseTestDtLocal.Name = "btnBrowseTestDtLocal";
            this.btnBrowseTestDtLocal.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTestDtLocal.TabIndex = 7;
            this.btnBrowseTestDtLocal.Text = "Browse";
            this.btnBrowseTestDtLocal.UseVisualStyleBackColor = true;
            this.btnBrowseTestDtLocal.Click += new System.EventHandler(this.btnBrowseTestDtLocal_Click);
            // 
            // btnBrowseTrainDtLocal
            // 
            this.btnBrowseTrainDtLocal.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBrowseTrainDtLocal.Location = new System.Drawing.Point(222, 60);
            this.btnBrowseTrainDtLocal.Name = "btnBrowseTrainDtLocal";
            this.btnBrowseTrainDtLocal.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTrainDtLocal.TabIndex = 6;
            this.btnBrowseTrainDtLocal.Text = "Browse";
            this.btnBrowseTrainDtLocal.UseVisualStyleBackColor = true;
            this.btnBrowseTrainDtLocal.Click += new System.EventHandler(this.btnBrowseTrainDtLocal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(42, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Model Build Status";
            // 
            // txtBuildStatus
            // 
            this.txtBuildStatus.Enabled = false;
            this.txtBuildStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBuildStatus.Location = new System.Drawing.Point(197, 290);
            this.txtBuildStatus.Name = "txtBuildStatus";
            this.txtBuildStatus.Size = new System.Drawing.Size(100, 23);
            this.txtBuildStatus.TabIndex = 4;
            // 
            // btnBuildModel
            // 
            this.btnBuildModel.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBuildModel.Location = new System.Drawing.Point(546, 286);
            this.btnBuildModel.Name = "btnBuildModel";
            this.btnBuildModel.Size = new System.Drawing.Size(114, 26);
            this.btnBuildModel.TabIndex = 2;
            this.btnBuildModel.Text = "Build Model";
            this.btnBuildModel.UseVisualStyleBackColor = true;
            this.btnBuildModel.Click += new System.EventHandler(this.btnBuildModel_Click);
            // 
            // LblTestDataLocation
            // 
            this.LblTestDataLocation.AutoSize = true;
            this.LblTestDataLocation.Font = new System.Drawing.Font("Arial", 12F);
            this.LblTestDataLocation.Location = new System.Drawing.Point(42, 136);
            this.LblTestDataLocation.Name = "LblTestDataLocation";
            this.LblTestDataLocation.Size = new System.Drawing.Size(138, 18);
            this.LblTestDataLocation.TabIndex = 1;
            this.LblTestDataLocation.Text = "Test Data Location";
            // 
            // lblTrainDataLocation
            // 
            this.lblTrainDataLocation.AutoSize = true;
            this.lblTrainDataLocation.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTrainDataLocation.Location = new System.Drawing.Point(42, 58);
            this.lblTrainDataLocation.Name = "lblTrainDataLocation";
            this.lblTrainDataLocation.Size = new System.Drawing.Size(144, 18);
            this.lblTrainDataLocation.TabIndex = 0;
            this.lblTrainDataLocation.Text = "Train Data Location";
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lblAuthor);
            this.tabAbout.Controls.Add(this.txtAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(768, 400);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAuthor.Location = new System.Drawing.Point(303, 353);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(178, 18);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author - Pradeep Shukla";
            // 
            // txtAbout
            // 
            this.txtAbout.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAbout.Location = new System.Drawing.Point(23, 17);
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(719, 313);
            this.txtAbout.TabIndex = 0;
            // 
            // openFileTrainData
            // 
            this.openFileTrainData.Filter = "\"tsv files (*.tsv)|*.tsv;";
            this.openFileTrainData.Title = "\"Please select  tsv\"";
            // 
            // openFileTestData
            // 
            this.openFileTestData.Filter = "\"tsv files (*.tsv)|*.tsv;";
            this.openFileTestData.Title = "\"Please select  tsv\"";
            // 
            // openFileModel
            // 
            this.openFileModel.Filter = "\"zip file (*.zip)|*.zip;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "MLClassification";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabgetDocType.ResumeLayout(false);
            this.tabgetDocType.PerformLayout();
            this.tabBuildModel.ResumeLayout(false);
            this.tabBuildModel.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputData;
        private System.Windows.Forms.Label lblOcrData;
        private System.Windows.Forms.Label lblDoctype;
        private System.Windows.Forms.TextBox txtDocType;
        private System.Windows.Forms.Label lblConfidence;
        private System.Windows.Forms.TextBox txtConfidence;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabgetDocType;
        private System.Windows.Forms.Button btnResetGetDocTypePage;
        private System.Windows.Forms.TabPage tabBuildModel;
        private System.Windows.Forms.TextBox txtBoxTestData;
        private System.Windows.Forms.TextBox txtBoxTrainData;
        private System.Windows.Forms.Button btnBrowseTestDtLocal;
        private System.Windows.Forms.Button btnBrowseTrainDtLocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuildStatus;
        private System.Windows.Forms.Button btnBuildModel;
        private System.Windows.Forms.Label LblTestDataLocation;
        private System.Windows.Forms.Label lblTrainDataLocation;
        private System.Windows.Forms.OpenFileDialog openFileTrainData;
        private System.Windows.Forms.OpenFileDialog openFileTestData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtSaveModelLocation;
        private System.Windows.Forms.Button btnSBrowseModelFolder;
        private System.Windows.Forms.Label lblModelStorePath;
        private System.Windows.Forms.FolderBrowserDialog openFolderModelLocation;
        private System.Windows.Forms.Button btnGetDoctype;
        private System.Windows.Forms.TextBox txtSelectedModel;
        private System.Windows.Forms.Button btnSelectModel;
        private System.Windows.Forms.Label lblModelPath;
        private System.Windows.Forms.OpenFileDialog openFileModel;
        private System.Windows.Forms.Button btnResetBuildModelPage;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.TextBox txtAbout;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtModelAccuracy;
        private System.Windows.Forms.Label lblModelAccuracy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

