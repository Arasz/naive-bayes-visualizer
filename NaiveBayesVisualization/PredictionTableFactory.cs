using System.Collections.Generic;
using System.Drawing;
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
            Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            var Title = new Label
            {
                Text = "Distributions for decision",
                Font = new Font("Arial", 10),
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.None,
                AutoSize = true
            };
            Table.Controls.Add(Title, 0, 0);
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
                chart.Titles.Add($"P({columns[i].ColumnName}={columns[i].Values[decision]}|y)");
                Table.Controls.Add(chart, 0, i+1);
            }
        }
    }
}