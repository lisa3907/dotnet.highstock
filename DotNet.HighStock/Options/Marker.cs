using DotNet.HighStock.Helpers;
using System.Drawing;

namespace DotNet.HighStock.Options
{
    /// <summary>
    /// 
    /// </summary>
    public class Marker
    {
        /// <summary>
        /// Enable or disable the point marker. If null, the markers are hidden when the data is dense, and shown for more widespread data points.
        /// Defaults to false.
        /// </summary>
        public bool? Enabled
        {
            get; set;
        }

        /// <summary>
        /// The threshold for how dense the point markers should be before they are hidden, given that enabled is not defined. The number indicates the horizontal distance between the two closest points in the series, as multiples of the marker.radius. In other words, the default value of 2 means points are hidden if overlapping horizontally.
        /// Defaults to 2.
        /// </summary>
        public Number? EnabledThreshold
        {
            get; set;
        }

        /// <summary>
        /// The fill color of the point marker. When null, the series' or point's color is used.
        /// Defaults to null.
        /// </summary>
        public Color? FillColor
        {
            get; set;
        }

        /// <summary>
        /// Image markers only. Set the image width explicitly. When using this option, a width must also be set.
        /// Defaults to null.
        /// </summary>
        public Number? Height
        {
            get; set;
        }

        /// <summary>
        /// The color of the point marker's outline. When null, the series' or point's color is used.
        /// Defaults to #ffffff.
        /// </summary>
        public Color? LineColor
        {
            get; set;
        }

        /// <summary>
        /// The width of the point marker's outline.
        /// Defaults to 0. 
        /// </summary>
        public Number? LineWidth
        {
            get; set;
        }

        /// <summary>
        /// The radius of the point marker.
        /// Defaults to 4.
        /// </summary>
        public Number? Radius
        {
            get; set;
        }

        ///// <summary>
        ///// States for a single point marker.
        ///// </summary>
        //public ? States { get; set; }

        /// <summary>
        /// A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols. Other possible values are "circle", "square", "diamond", "triangle" and "triangle-down".
        /// Additionally, the URL to a graphic can be given on this form: "url(graphic.png)". Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.
        /// Custom callbacks for symbol path generation can also be added to Highcharts.SVGRenderer.prototype.symbols.The callback is then used by its method name, as shown in the demo.
        /// Defaults to null.
        /// </summary>
        public string Symbol
        {
            get; set;
        }

        /// <summary>
        /// Image markers only. Set the image width explicitly. When using this option, a height must also be set.
        /// Defaults to null.
        /// </summary>
        public Number? Width
        {
            get; set;
        }
    }
}