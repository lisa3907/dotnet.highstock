using DotNet.HighStock.Attributes;
using DotNet.HighStock.Options;

namespace DotNet.HighStock.Helpers
{
    public class Data
    {
        public Data(object[] data)
        {
            ArrayData = data;
        }

        public Data(object[,] data)
        {
            DoubleArrayData = data;
        }

        public Data(Point[] data)
        {
            Points = data;
        }

        public Data(SeriesData[] data)
        {
            SeriesData = data;
        }

        [Name("data")]
        public object[] ArrayData
        {
            get;
            private set;
        }

        [Name("data")]
        public object[,] DoubleArrayData
        {
            get;
            private set;
        }

        [Name("data")]
        public Point[] Points
        {
            get;
            private set;
        }

        [Name("data")]
        public SeriesData[] SeriesData
        {
            get;
            private set;
        }
    }
}