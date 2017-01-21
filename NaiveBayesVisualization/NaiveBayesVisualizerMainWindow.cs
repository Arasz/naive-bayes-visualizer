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

        private Chart CreateChart(string[] seriesArray, double[] pointsArray, bool showLegend)
        {
            var chart = new Chart();
            var style = new LabelStyle {Enabled = false};
            var area = new ChartArea
            {
                AxisY =
                {
                    Interval = 2.0,
                    Maximum = 1.0,
                    Minimum = 0.0,
                    LabelAutoFitStyle = LabelAutoFitStyles.None,
                    LabelStyle = style
                },
                AxisX =
                {
                    Interval = 5.0,
                    LabelAutoFitStyle = LabelAutoFitStyles.None,
                    LabelStyle = style
                }
            };
            chart.ChartAreas.Add(area);
            // Set palette.
            chart.Palette = ChartColorPalette.BrightPastel;

            // Add series.
            for (var i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                var series = chart.Series.Add(seriesArray[i]);

                // Add point.
                series.Points.Add(pointsArray[i]);
                chart.Series[i]["PointWidth"] = "2";
            }
            if (showLegend)
            {
                chart.Legends.Add(new Legend());
                //area.Visible = false;
            }
            return chart;
        }

        private void LoadDataFromFile(object sender, EventArgs e)
        {
            var result = openDataFileDialog.ShowDialog();
            if (result != DialogResult.OK) return;

            var dataReader = new CsvDataReader(openDataFileDialog.FileName);
            _experimentData = new ExperimentData(dataReader);

            var distributionTable = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            DistributionPanel.Controls.Add(distributionTable);

            distributionTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            distributionTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            distributionTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            var numRows = (float)_experimentData.ColumnLabels.Count - 1;
            for (var i = 0; i < numRows; i++)
            {
                distributionTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
                var chart = CreateChart(_experimentData.Codebook.Columns[i].Values, _experimentData.NaiveBayes.Distributions[0, i], false);
                distributionTable.Controls.Add(chart, 0, i);
                var chart2 = CreateChart(_experimentData.Codebook.Columns[i].Values, _experimentData.NaiveBayes.Distributions[1, i], true);
                distributionTable.Controls.Add(chart2, 1, i);
            }

        }
    }
}