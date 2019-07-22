using DotNet.HighStock.Helpers;
using System.Drawing;

namespace DotNet.HighStock.Options
{
    /// <summary>
    /// The bottom of the frame around a 3D chart.
    /// </summary>
    public class ChartOptions3dFrameBottom
    {
        /// <summary>
        /// The color of the panel.
        /// Default: transparent
        /// </summary>
        public Color? Color
        {
            get; set;
        }

        /// <summary>
        /// The thickness of the panel.
        /// Default: 1
        /// </summary>
        public Number? Size
        {
            get; set;
        }
    }
}