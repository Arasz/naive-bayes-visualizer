using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace NaiveBayesVisualization
{
    public class MatrixChartFactory
    {
        public Chart Chart { get; }

        public MatrixChartFactory(string[] seriesArray, double[] pointsArray)
        {

            Chart = new Chart();
            var style = new LabelStyle {Enabled = false};
            var area = new ChartArea
            {
                AxisY =
                {
                    Interval = 0.5,
                    Maximum = 1.0,
                    Minimum = 0.0,
                    LabelAutoFitStyle = LabelAutoFitStyles.None
                },
                AxisX =
                {
                    Interval = 5.0,
                    LabelAutoFitStyle = LabelAutoFitStyles.None,
                    LabelStyle = style
                }
            };
            Chart.ChartAreas.Add(area);
            // Set palette.
            Chart.Palette = ChartColorPalette.BrightPastel;

            // Add series.
            for (var i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                var series = Chart.Series.Add(seriesArray[i]);

                // Add point.
                series.Points.Add(pointsArray[i]);
                Chart.Series[i]["PointWidth"] = "2";
            }
        }
    }
}