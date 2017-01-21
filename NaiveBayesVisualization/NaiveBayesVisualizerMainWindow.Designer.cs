﻿namespace NaiveBayesVisualization
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
            this.PredictionSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PriorsPanel = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DistributionPanel = new System.Windows.Forms.Panel();
            this.DistributionsPage = new System.Windows.Forms.TabControl();
            this.toolStrip.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionSplitContainer)).BeginInit();
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
            this.tabPage3.Controls.Add(this.PredictionSplitContainer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(901, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PredictionSplitContainer
            // 
            this.PredictionSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredictionSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.PredictionSplitContainer.Name = "PredictionSplitContainer";
            // 
            // PredictionSplitContainer.Panel1
            // 
            this.PredictionSplitContainer.Panel1.AutoScroll = true;
            this.PredictionSplitContainer.Panel1MinSize = 200;
            // 
            // PredictionSplitContainer.Panel2
            // 
            this.PredictionSplitContainer.Panel2.UseWaitCursor = true;
            this.PredictionSplitContainer.Panel2MinSize = 200;
            this.PredictionSplitContainer.Size = new System.Drawing.Size(895, 560);
            this.PredictionSplitContainer.SplitterDistance = 500;
            this.PredictionSplitContainer.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PriorsPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PriorsPanel
            // 
            this.PriorsPanel.Location = new System.Drawing.Point(0, 0);
            this.PriorsPanel.Name = "PriorsPanel";
            this.PriorsPanel.Size = new System.Drawing.Size(901, 566);
            this.PriorsPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DistributionPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DistributionPanel
            // 
            this.DistributionPanel.AutoScroll = true;
            this.DistributionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DistributionPanel.Location = new System.Drawing.Point(0, 0);
            this.DistributionPanel.Name = "DistributionPanel";
            this.DistributionPanel.Size = new System.Drawing.Size(901, 566);
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
            // NaiveBayesVisualizerMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 617);
            this.Controls.Add(this.DistributionsPage);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NaiveBayesVisualizerMainWindow";
            this.Text = "NaiveBayesVisualizer";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PredictionSplitContainer)).EndInit();
            this.PredictionSplitContainer.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
    }
}

