using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NaiveBayesVisualization.Data;

namespace NaiveBayesVisualization
{
    public partial class NaiveBayesVisualizerMainWindow : Form
    {
        private ExperimentData _experimentData;

        public NaiveBayesVisualizerMainWindow()
        {
            InitializeComponent();
        }


        private void LoadDataFromFile(object sender, EventArgs e)
        {
            var result = openDataFileDialog.ShowDialog();
            if (result != DialogResult.OK) return;

            var dataReader = new CsvDataReader(openDataFileDialog.FileName);
            _experimentData = new ExperimentData(dataReader);
            var rowsCount = _experimentData.ColumnLabels.Count - 1;

            var priorisChart = new CustomChartFactory(
                _experimentData.Codebook.Columns[rowsCount].Values,
                _experimentData.Priors).Chart;
            priorisChart.Legends.Add(new Legend());
            priorisChart.Width = 300;
            priorisChart.Height = 100;
            PriorsPanel.Controls.Add(priorisChart);

            DistributionPanel.Controls.Add(
                new DistributionTableFactory(
                    _experimentData.Codebook.Columns,
                    _experimentData.Distributions,
                    rowsCount
                ).Table);
        }
    }
}