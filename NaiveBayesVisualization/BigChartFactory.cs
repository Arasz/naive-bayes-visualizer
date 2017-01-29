using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NaiveBayesVisualization
{
    class BigChartFactory
    {
        public Chart Chart { get; }

        public BigChartFactory(string[] seriesArray, double[] pointsArray)
        {
            Chart = new Chart
            {
                Width = 600,
                Height = 500,
                Anchor = AnchorStyles.None
            };
            var style = new LabelStyle {Enabled = false};
            var area = new ChartArea
            {
                AxisY =
                {
                    Interval = 0.25,
                    Maximum = 1.0,
                    Minimum = 0.0,
                    LabelAutoFitStyle = LabelAutoFitStyles.None,
                },
                AxisX =
                {
                    Interval = 10.0,
                    LabelAutoFitStyle = LabelAutoFitStyles.None,
                    LabelStyle = style
                }
            };
            Chart.ChartAreas.Add(area);
            // Set palette.
            Chart.Palette = ChartColorPalette.BrightPastel;
            Chart.Legends.Add(new Legend()
            {
                Font = new Font("Arial", 10)
            });
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