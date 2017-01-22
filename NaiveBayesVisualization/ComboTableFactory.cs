using System;
using System.Drawing;
using System.Windows.Forms;
using Accord.Statistics.Filters;

namespace NaiveBayesVisualization
{
    class ComboTableFactory
    {
        public TableLayoutPanel Table { get; }

        public ComboTableFactory(ColumnOptionCollection<Codification.Options> columns,
            EventHandler itemChanged,
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
                var table = new TableLayoutPanel();
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 0.5F));
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 0.5F));
                var comboBox = new ComboBox
                {
                    DataSource = columns[i].Values,
                    Tag = $"{i}"
                };
                comboBox.SelectedIndexChanged += itemChanged;
                var label = new Label
                {
                    Text = columns[i].ColumnName,
                    BackColor = Color.Transparent
                };
                table.Controls.Add(label, 0, 0);
                table.Controls.Add(comboBox, 0, 1);
                Table.Controls.Add(table, 0, i);
            }
        }
    }
}