﻿using System;
using System.Drawing;
using System.Windows.Forms;
using NaiveBayesVisualization.Data;

namespace NaiveBayesVisualization
{
    public partial class NaiveBayesVisualizerMainWindow : Form
    {
        private ExperimentData _experimentData;
        private int _rowsCount;
        private string[] _decisions;
        private TableLayoutPanel _predictionsTable;

        public NaiveBayesVisualizerMainWindow()
        {
            InitializeComponent();
        }


        private void LoadDataFromFile(object sender, EventArgs e)
        {
            var result = openDataFileDialog.ShowDialog();
            if (result != DialogResult.OK) return;

            CleanPanels();
            PrepareData();
        }

        private void CleanPanels()
        {
            DistributionPanel.Controls.Clear();
            PriorsPanel.Controls.Clear();
            PredictionSplitContainer.Panel1.Controls.Clear();
            PredictionSplitContainer.Panel2.Controls.Clear();
        }

        private void PrepareData()
        {
            var dataReader = new CsvDataReader(openDataFileDialog.FileName);
            _experimentData = new ExperimentData(dataReader);
            _rowsCount = _experimentData.ColumnLabels.Count - 1;
            _decisions = _experimentData.GenerateTestDecisions();

            var priorisChart = new BigChartFactory(
                _experimentData.Codebook.Columns[_rowsCount].Values,
                _experimentData.Priors).Chart;
            priorisChart.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            PriorsPanel.Controls.Add(priorisChart);

            DistributionPanel.Controls.Add(
                new DistributionTableFactory(
                    _experimentData.Codebook.Columns,
                    _experimentData.Distributions,
                    _rowsCount
                ).Table);
            LoadComboBoxes();
            LoadPredictions();
        }

        private void LoadComboBoxes()
        {
            var comboTable = new ComboTableFactory(_experimentData.Codebook.Columns,
                ItemChanged,
                _rowsCount).Table;
            PredictionSplitContainer.Panel1.Controls.Add(comboTable);
        }

        private void LoadPredictions()
        {

            PredictionSplitContainer.Panel1.Controls.Remove(_predictionsTable);
            var decisions = _experimentData.TranslateDecisions(_decisions);
            _predictionsTable = new PredictionTableFactory(
                _experimentData.Codebook.Columns,
                _experimentData.Distributions,
                decisions,
                _rowsCount
            ).Table;
            _predictionsTable.Location = new Point(160, 0);
            PredictionSplitContainer.Panel1.Controls.Add(_predictionsTable);

            PredictionSplitContainer.Panel2.Controls.Clear();
            var probabilities = _experimentData.Predict(_decisions);
            var decisionChart = new BigChartFactory(_experimentData.Codebook.Columns[_rowsCount].Values,
                probabilities).Chart;
            decisionChart.Width = 300;
            decisionChart.Height = 300;
            PredictionSplitContainer.Panel2.Controls.Add(decisionChart);
        }


        public void ItemChanged(object sender, EventArgs e)
        {
            var senderCombo = (ComboBox) sender;
            var senderIndex = int.Parse(senderCombo.Tag + "");
            _decisions[senderIndex] = senderCombo.SelectedItem.ToString();
            LoadPredictions();
        }
    }
}