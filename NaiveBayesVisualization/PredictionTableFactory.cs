using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Accord.Statistics.Filters;

namespace NaiveBayesVisualization
{
    class PredictionTableFactory
    {
        public TableLayoutPanel Table { get; }

        public PredictionTableFactory(ColumnOptionCollection<Codification.Options> columns,
            double[,][] distributions, int[] decisions,
            int numRows)
        {
            Table = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            for (var i = 0; i < numRows; i++)
            {
                Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));

                var decision = decisions[i];
                var values = new[]
                {
                    distributions[0, i][decision],
                    distributions[1, i][decision]
                };
                var chart =
                    new MatrixChartFactory(columns[numRows].Values,
                        values).Chart;
                chart.Legends.Add(new Legend());

                Table.Controls.Add(chart, 0, i);
            }
        }
    }
}