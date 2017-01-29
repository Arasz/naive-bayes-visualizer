namespace NaiveBayesVisualization
{
    partial class NaiveBayesVisualizerMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaiveBayesVisualizerMainWindow));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.loadDataButton = new System.Windows.Forms.ToolStripButton();
            this.openDataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PredictionsTabTitle = new System.Windows.Forms.Label();
            this.PredictionSplitContainer = new System.Windows.Forms.SplitContainer();
            this.decisionTitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ProriTabTitle = new System.Windows.Forms.Label();
            this.PriorsPanel = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DistributionsTabTitle = new System.Windows.Forms.Label();
            this.DistributionPanel = new System.Windows.Forms.Panel();
            this.DistributionsPage = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DistributionsFordecisionLabel = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionSplitContainer)).BeginInit();
            this.PredictionSplitContainer.Panel1.SuspendLayout();
            this.PredictionSplitContainer.Panel2.SuspendLayout();
            this.PredictionSplitContainer.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.DistributionsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(909, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "Tool strip";
            // 
            // loadDataButton
            // 
            this.loadDataButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadDataButton.Image = global::NaiveBayesVisualization.Properties.Resources._1484516837_BT_folder_file_open;
            this.loadDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(23, 22);
            this.loadDataButton.Text = "toolStripButton1";
            this.loadDataButton.Click += new System.EventHandler(this.LoadDataFromFile);
            // 
            // openDataFileDialog
            // 
            this.openDataFileDialog.AddExtension = false;
            this.openDataFileDialog.FileName = "D:\\Library\\Documents\\GitHub\\Active\\naive-bayes-visualization\\Data\\Mushrooms";
            this.openDataFileDialog.Filter = "CSV files|*.csv";
            this.openDataFileDialog.InitialDirectory = "../../Data/";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PredictionsTabTitle);
            this.tabPage3.Controls.Add(this.PredictionSplitContainer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(901, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "predictions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PredictionsTabTitle
            // 
            this.PredictionsTabTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PredictionsTabTitle.AutoSize = true;
            this.PredictionsTabTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PredictionsTabTitle.Location = new System.Drawing.Point(380, 3);
            this.PredictionsTabTitle.Name = "PredictionsTabTitle";
            this.PredictionsTabTitle.Size = new System.Drawing.Size(103, 24);
            this.PredictionsTabTitle.TabIndex = 2;
            this.PredictionsTabTitle.Text = "Predictions";
            // 
            // PredictionSplitContainer
            // 
            this.PredictionSplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.PredictionSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredictionSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.PredictionSplitContainer.Name = "PredictionSplitContainer";
            // 
            // PredictionSplitContainer.Panel1
            // 
            this.PredictionSplitContainer.Panel1.AutoScroll = true;
            this.PredictionSplitContainer.Panel1.Controls.Add(this.DistributionsFordecisionLabel);
            this.PredictionSplitContainer.Panel1MinSize = 200;
            // 
            // PredictionSplitContainer.Panel2
            // 
            this.PredictionSplitContainer.Panel2.Controls.Add(this.decisionTitle);
            this.PredictionSplitContainer.Panel2.UseWaitCursor = true;
            this.PredictionSplitContainer.Panel2MinSize = 200;
            this.PredictionSplitContainer.Size = new System.Drawing.Size(895, 560);
            this.PredictionSplitContainer.SplitterDistance = 500;
            this.PredictionSplitContainer.TabIndex = 0;
            // 
            // decisionTitle
            // 
            this.decisionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.decisionTitle.AutoSize = true;
            this.decisionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decisionTitle.Location = new System.Drawing.Point(159, 30);
            this.decisionTitle.Name = "decisionTitle";
            this.decisionTitle.Size = new System.Drawing.Size(0, 24);
            this.decisionTitle.TabIndex = 3;
            this.decisionTitle.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ProriTabTitle);
            this.tabPage2.Controls.Add(this.PriorsPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "priori";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ProriTabTitle
            // 
            this.ProriTabTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProriTabTitle.AutoSize = true;
            this.ProriTabTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProriTabTitle.Location = new System.Drawing.Point(356, 3);
            this.ProriTabTitle.Name = "ProriTabTitle";
            this.ProriTabTitle.Size = new System.Drawing.Size(251, 24);
            this.ProriTabTitle.TabIndex = 1;
            this.ProriTabTitle.Text = "Priori probabilities for classes";
            // 
            // PriorsPanel
            // 
            this.PriorsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorsPanel.Location = new System.Drawing.Point(0, 30);
            this.PriorsPanel.Name = "PriorsPanel";
            this.PriorsPanel.Size = new System.Drawing.Size(901, 536);
            this.PriorsPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DistributionsTabTitle);
            this.tabPage1.Controls.Add(this.DistributionPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "distributions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DistributionsTabTitle
            // 
            this.DistributionsTabTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DistributionsTabTitle.AutoSize = true;
            this.DistributionsTabTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistributionsTabTitle.Location = new System.Drawing.Point(386, 3);
            this.DistributionsTabTitle.Name = "DistributionsTabTitle";
            this.DistributionsTabTitle.Size = new System.Drawing.Size(111, 24);
            this.DistributionsTabTitle.TabIndex = 2;
            this.DistributionsTabTitle.Text = "Distributions";
            // 
            // DistributionPanel
            // 
            this.DistributionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistributionPanel.AutoScroll = true;
            this.DistributionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DistributionPanel.Location = new System.Drawing.Point(4, 30);
            this.DistributionPanel.Name = "DistributionPanel";
            this.DistributionPanel.Size = new System.Drawing.Size(901, 536);
            this.DistributionPanel.TabIndex = 0;
            // 
            // DistributionsPage
            // 
            this.DistributionsPage.Controls.Add(this.tabPage1);
            this.DistributionsPage.Controls.Add(this.tabPage2);
            this.DistributionsPage.Controls.Add(this.tabPage3);
            this.DistributionsPage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DistributionsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DistributionsPage.Location = new System.Drawing.Point(0, 25);
            this.DistributionsPage.Multiline = true;
            this.DistributionsPage.Name = "DistributionsPage";
            this.DistributionsPage.SelectedIndex = 0;
            this.DistributionsPage.Size = new System.Drawing.Size(909, 592);
            this.DistributionsPage.TabIndex = 1;
            this.DistributionsPage.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(674, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 2;
            // 
            // DistributionsFordecisionLabel
            // 
            this.DistributionsFordecisionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DistributionsFordecisionLabel.AutoSize = true;
            this.DistributionsFordecisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DistributionsFordecisionLabel.Location = new System.Drawing.Point(170, 30);
            this.DistributionsFordecisionLabel.Name = "DistributionsFordecisionLabel";
            this.DistributionsFordecisionLabel.Size = new System.Drawing.Size(0, 20);
            this.DistributionsFordecisionLabel.TabIndex = 3;
            // 
            // NaiveBayesVisualizerMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DistributionsPage);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NaiveBayesVisualizerMainWindow";
            this.Text = "NaiveBayesVisualizer";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.PredictionSplitContainer.Panel1.ResumeLayout(false);
            this.PredictionSplitContainer.Panel1.PerformLayout();
            this.PredictionSplitContainer.Panel2.ResumeLayout(false);
            this.PredictionSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionSplitContainer)).EndInit();
            this.PredictionSplitContainer.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.DistributionsPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton loadDataButton;
        private System.Windows.Forms.OpenFileDialog openDataFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PriorsPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel DistributionPanel;
        private System.Windows.Forms.TabControl DistributionsPage;
        private System.Windows.Forms.SplitContainer PredictionSplitContainer;
        private System.Windows.Forms.Label ProriTabTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DistributionsTabTitle;
        private System.Windows.Forms.Label PredictionsTabTitle;
        private System.Windows.Forms.Label decisionTitle;
        private System.Windows.Forms.Label DistributionsFordecisionLabel;
    }
}

