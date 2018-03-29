using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
    /// <summary>
    /// The navigator is a small series below the main series, displaying a view of the entire data set. It provides tools to zoom in and out on parts of the data as well as panning across the dataset.
    /// </summary>
    public class Navigator
    {
        /// <summary>
        /// Whether the navigator and scrollbar should adapt to updated data in the base X axis. This should be false when loading data asynchronously, to prevent circular loading. 
        /// Defaults to true.
        /// </summary>
        public bool? AdaptToUpdatedData
        {
            get;
            set;
        }

        /// <summary>
        /// An integer identifying the index to use for the base series, or a string representing the id of the series. 
        /// Defaults to 0.
        /// </summary>
        public Number? BaseSeries
        {
            get;
            set;
        }

        /// <summary>
        /// Enable or disable the navigator. 
        /// Defaults to true.
        /// </summary>
        [JsonFormatter("{{ 0 }}")]
        public bool? Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// Options for the handles for dragging the zoomed area. Available options are backgroundColor (defaults to #ebe7e8) and borderColor
        /// defaults to #b2b1b6
        /// </summary>
        public Object Handles
        {
            get;
            set;
        }

        /// <summary>
        /// The height of the navigator. 
        /// Defaults to 40.
        /// </summary>
        public Number? Height
        {
            get;
            set;
        }

        /// <summary>
        /// The distance from the nearest element, the X axis or X axis labels. 
        /// Defaults to 25.
        /// </summary>
        public Number? Margin
        {
            get;
            set;
        }

        /// <summary>
        /// The color of the mask covering the areas of the navigator series that are currently not visible in the main series. 
        /// The default color is bluish with an opacity of 0.3 to see the series below. Defaults to rgba(128,179,236,0.3).
        /// </summary>
        public Color? MaskFill
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the mask should be inside the range marking the zoomed range, or outside. In Highstock 1.x it was always false. 
        /// Defaults to true.
        /// </summary>
        public bool? MaskInside
        {
            get;
            set;
        }

        /// <summary>
        /// The color of the line marking the currently zoomed area in the navigator. 
        /// Defaults to #b2b1b6.
        /// </summary>
        public Color? OutlineColor
        {
            get;
            set;
        }

        /// <summary>
        /// The width of the line marking the currently zoomed area in the navigator. 
        /// Defaults to 2.
        /// </summary>
        public Number? OutlineWidth
        {
            get;
            set;
        }
    }
}