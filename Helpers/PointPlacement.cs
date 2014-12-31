using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Enums;

namespace DotNet.Highstock.Helpers
{
    public class PointPlacement
    {
        public PointPlacement(Placement location) { Location = location; }

        public PointPlacement(double position) { Position = position; }


        [Name("pointPlacement")]
        public Placement? Location { get; private set; }
        [Name("pointPlacement")]
        public double? Position { get; private set; }
    }
}
