
namespace System.Windows.Forms
{
    internal class DataVisualization
    {
        internal class Charting
        {
            public static object ChartColorPalette { get; internal set; }

            internal class ChartArea
            {
                public string Name { get; internal set; }
            }

            internal class Series
            {
                public string Legend { get; internal set; }
                public string Name { get; internal set; }
                public object ChartType { get; internal set; }
                public string ChartArea { get; internal set; }
            }

            internal class Legend
            {
                public string Name { get; internal set; }
            }

            internal class Chart
            {
                public Chart()
                {
                }

                public string Text { get; internal set; }
                public int TabIndex { get; internal set; }
                public object Series { get; internal set; }
                public Size Size { get; internal set; }
                public object Palette { get; internal set; }
                public string Name { get; internal set; }
                public Point Location { get; internal set; }
                public object Legends { get; internal set; }
                public object ChartAreas { get; internal set; }
            }
        }
    }
}