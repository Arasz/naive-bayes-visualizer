using System.Drawing;
using System.Linq;
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
            Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            for (var i = 0; i < numColumns; i++)
            {
                var label = new Label
                {
                    Text = columns[numRows].Values[i],
                    Font = new Font("Arial", 10)
                };
                Table.Controls.Add(label, i, 0);
            }
            Table.Controls.Add(new Label(), numColumns, 0);

            for (var j = 0; j < numColumns; j++)
            {
                Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
                for (var i = 0; i < numRows; i++)
                {
                    Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
                    var chart =
                        new MatrixChartFactory(columns[i].Values,
                            distributions[j, i]).Chart;
                    Table.Controls.Add(chart, j, i+1);
                }
            }
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            for (var i = 0; i < numRows; i++)
            {
                var chart2 =
                    new MatrixChartFactory(columns[i].Values,
                        distributions[0, i]).Chart;
                chart2.ChartAreas.First().Visible = false;
                Table.Controls.Add(chart2, numColumns, i+1);
                chart2.Legends.Add(new Legend());
            }
        }
    }
}