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
            this.DistributionsPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DistributionPanel = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openDataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip.SuspendLayout();
            this.DistributionsPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // DistributionsPage
            // 
            this.DistributionsPage.Controls.Add(this.tabPage1);
            this.DistributionsPage.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openDataFileDialog
            // 
            this.openDataFileDialog.AddExtension = false;
            this.openDataFileDialog.FileName = "D:\\Library\\Documents\\GitHub\\Active\\naive-bayes-visualization\\Data\\Mushrooms";
            this.openDataFileDialog.Filter = "CSV files|*.csv";
            this.openDataFileDialog.InitialDirectory = "../../Data/";
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
            this.DistributionsPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.TabControl DistributionsPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripButton loadDataButton;
        private System.Windows.Forms.OpenFileDialog openDataFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel DistributionPanel;
    }
}

