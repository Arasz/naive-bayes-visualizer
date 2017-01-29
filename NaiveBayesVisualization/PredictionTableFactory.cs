using System.Collections.Generic;
using System.Windows.Forms;
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
                Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));

                var decision = decisions[i];
                var numColumns = columns[numRows].Values.Length;
                var values = new List<double>();
                for (var j = 0; j  <numColumns; j++)
                {
                    values.Add(distributions[j, i][decision]);
                }
                var chart =
                    new MatrixChartFactory(columns[numRows].Values,
                        values.ToArray()).Chart;

                Table.Controls.Add(chart, 0, i);
            }
        }
    }
}