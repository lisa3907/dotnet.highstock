using System;
using Windows.UI;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
    /// <summary>
    /// The chart's subtitle
    /// </summary>
    public class Subtitle
    {
        /// <summary>
        /// The horizontal alignment of the subtitle. Can be one of 'left', 'center' and 'right'.
        /// Default: center
        /// </summary>
        public HorizontalAligns? Align
        {
            get;
            set;
        }

        /// <summary>
        /// When the subtitle is floating, the plot area will not move to make space for it.
        /// Default: false
        /// </summary>
        public bool? Floating
        {
            get;
            set;
        }

        /// <summary>
        /// CSS styles for the title. Exact positioning of the title can be achieved by changing the margin property, or by adding <code>position: 'absolute'</code> and  left and top properties.
        /// Default: { "color": "#555555" }
        /// </summary>
        [JsonFormatter("{{ {0} }}")]
        public string Style
        {
            get;
            set;
        }

        /// <summary>
        /// The subtitle of the chart.
        /// </summary>
        public string Text
        {
            get;
            set;
        }

        /// <summary>
        /// Whether to <a href='http://www.highstock.com/docs/chart-concepts/labels-and-string-formatting#html'>use HTML</a> to render the text.
        /// Default: false
        /// </summary>
        public bool? UseHTML
        {
            get;
            set;
        }

        /// <summary>
        /// The vertical alignment of the title. Can be one of 'top', 'middle' and 'bottom'. When a value is given, the title behaves as floating.
        /// Default:  
        /// </summary>
        public VerticalAligns? VerticalAlign
        {
            get;
            set;
        }

        /// <summary>
        /// The x position of the subtitle relative to the alignment within chart.spacingLeft and chart.spacingRight.
        /// Default: 0
        /// </summary>
        public Number? X
        {
            get;
            set;
        }

        /// <summary>
        /// The y position of the subtitle relative to the alignment within chart.spacingTop and chart.spacingBottom. By default the subtitle is laid out below the title unless the title is floating.
        /// Default:  null
        /// </summary>
        public Number? Y
        {
            get;
            set;
        }

    }
}