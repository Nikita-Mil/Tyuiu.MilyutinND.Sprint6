namespace System.Windows.Forms
{
    internal class DataVisualization
    {
        internal class Charting
        {
            internal class Chart
            {
                internal string Text;

                public object ChartAreas { get; internal set; }
                public int TabIndex { get; internal set; }
                public object Series { get; internal set; }
            }

            internal class ChartArea
            {
            }

            internal class Legend
            {
                public string Name { get; internal set; }
            }

            internal class Series
            {
                public string ChartArea { get; internal set; }
            }
        }
    }
}