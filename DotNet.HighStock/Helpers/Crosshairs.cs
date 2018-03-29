using System.Drawing;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Enums;

namespace DotNet.HighStock.Helpers
{
    public class Crosshairs
    {
        public Crosshairs(bool showXCrosshairs) { ShowXCrosshairs = showXCrosshairs; }

        public Crosshairs(bool showXCrosshairs, bool sShowYCrosshairs) { ShowBothCrosshairs = new[] { showXCrosshairs, sShowYCrosshairs }; }

        public Crosshairs(CrosshairsForamt xCrosshairsForamt, CrosshairsForamt yCrosshairsForamt) { CrosshairsForamt = new[] { xCrosshairsForamt, yCrosshairsForamt }; }

        [Name("crosshairs")]
        public bool? ShowXCrosshairs { get; private set; }
        [Name("crosshairs")]
        public bool[] ShowBothCrosshairs { get; private set; }
        [Name("crosshairs")]
        public CrosshairsForamt[] CrosshairsForamt { get; private set; }
    }

    public class CrosshairsForamt
    {
        public int? Width { get; set; }
        public Color? Color { get; set; }
        public DashStyles DashStyle { get; set; }
        public int? ZIndex { get; set; }
    }
}