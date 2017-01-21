using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Accord.Statistics.Filters;

namespace NaiveBayesVisualization
{
    public class DistributionTableFactory
    {
        public TableLayoutPanel Table { get; }

        public DistributionTableFactory(ColumnOptionCollection<Codification.Options> columns, 
            double[,][] distributions,
            int numRows)
        {
            Table = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };
            var numColumns = columns[numRows].Values.Length;
            for (var j = 0; j < numColumns; j++)
            {
                Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                for (var i = 0; i < numRows; i++)
                {
                    Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
                    var chart =
                        new MatrixChartFactory(columns[i].Values,
                            distributions[j, i]).Chart;
                    Table.Controls.Add(chart, j, i);
                    if (j == numColumns - 1)
                    {
                        chart.Legends.Add(new Legend());
                    }
                }
            }
        }
    }
}
