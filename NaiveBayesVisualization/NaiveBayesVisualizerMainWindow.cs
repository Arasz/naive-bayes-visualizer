using System;
using System.Windows.Forms;
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
            learningDataGridView.DataSource = _experimentData.TrainData;
        }
    }
}