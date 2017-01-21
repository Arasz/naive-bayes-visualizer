using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
                var comboBox = new ComboBox
                {
                    DataSource = columns[i].Values,
                    Tag = $"{i}"
                };
                comboBox.SelectedIndexChanged += itemChanged;
                Table.Controls.Add(comboBox, 0, i);
            }
        }
    }
}