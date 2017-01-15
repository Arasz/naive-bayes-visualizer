using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (result == DialogResult.OK)
            {
                var dataReader = new CsvDataReader(openDataFileDialog.FileName);
                _experimentData = new ExperimentData(dataReader);
                _experimentData.Load();

                learningDataGridView.DataSource = _experimentData.TrainData;
            }
        }
    }
}