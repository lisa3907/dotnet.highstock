using DotNet.HighStock.Attributes;
using DotNet.HighStock.Enums;

namespace DotNet.HighStock.Helpers
{
    public class PointPlacement
    {
        public PointPlacement(Placement location)
        {
            Location = location;
        }

        public PointPlacement(double position)
        {
            Position = position;
        }

        [Name("pointPlacement")]
        public Placement? Location
        {
            get; private set;
        }

        [Name("pointPlacement")]
        public double? Position
        {
            get; private set;
        }
    }
}