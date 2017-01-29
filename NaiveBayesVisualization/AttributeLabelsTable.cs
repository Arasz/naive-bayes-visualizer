using System;
using System.Drawing;
using System.Windows.Forms;
using Accord.Statistics.Filters;

namespace NaiveBayesVisualization
{

    public class AttributeLabelsTable
    {
        public TableLayoutPanel Table { get; }

        public AttributeLabelsTable(ColumnOptionCollection<Codification<string>.Options> columns, int rowsCount)
        {
            Table = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };
            Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            for (var i = 0; i < rowsCount; i++)
            {
                Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
                var label = new Label
                {
                    Text = $"P({columns[i].ColumnName}|y)",
                    Font = new Font("Arial", 9),
                    BackColor = Color.Transparent,
                    AutoSize = true
                };
                Table.Controls.Add(label, 0, i+1);
            }
        }
    }
}
