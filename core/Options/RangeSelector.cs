using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
    /// <summary>
    /// The range selector is a tool for selecting ranges to display within the chart. It provides buttons to select preconfigured ranges in the chart, like 1 day, 1 week, 1 month etc. It also provides input boxes where min and max dates can be manually input.
    /// </summary>
    public class RangeSelector
    {
        /// <summary>
        /// Whether to enable all buttons from the start. By default buttons are only enabled if the corresponding time range exists on the X axis, but enabling all buttons allows for dynamically loading different time ranges. 
        /// Defaults to false.
        /// </summary>
        public bool? AllButtonsEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// The space in pixels between the buttons in the range selector. 
        /// Defaults to 0.
        /// </summary>
        public Number? ButtonSpacing
        {
            get;
            set;
        }

        /// <summary>
        /// A collection of attributes for the buttons. The object takes SVG attributes like fill, stroke, stroke-width, as well as style, a collection of CSS properties for the text.
        /// </summary>
        public Object ButtonTheme
        {
            get;
            set;
        }

        /// <summary>
        /// An array of configuration objects for the buttons. The individual options for each item are:
        /// 
        /// type: Defines the timespan, can be one of 'millisecond', 'second', 'minute', 'day', 'week', 'month', 'ytd' (year to date), 'year' and 'all'.
        /// count: Defines how many units of the defined type to use.
        /// text: The text for the button itself
        /// 
        /// Defaults to:<pre>buttons: [{
        ///         type: 'month',
        ///         count: 1,
        ///         text: '1m'
        /// }, {
        ///         type: 'month',
        ///         count: 3,
        ///         text: '3m'
        /// }, {
        ///         type: 'month',
        ///         count: 6,
        ///         text: '6m'
        /// }, {
        ///         type: 'ytd',
        ///         text: 'YTD'
        /// }, {
        ///         type: 'year',
        ///         count: 1,
        ///         text: '1y'
        /// }, {
        ///         type: 'all',
        ///         text: 'All'
        /// }]</pre>
        /// </summary>
        public ButtonsItems[] Buttons
        {
            get;
            set;
        }

        /// <summary>
        /// Enable or disable the range selector. 
        /// Defaults to true.
        /// </summary>
        public bool? Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// The border color of the date input boxes. 
        /// Defaults to silver.
        /// </summary>
        public Color? InputBoxBorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// The pixel height of the date input boxes. 
        /// Defaults to 17.
        /// </summary>
        public Number? InputBoxHeight
        {
            get;
            set;
        }

        /// <summary>
        /// CSS for the container DIV holding the input boxes. Deprecated as of 1.2.5. Use inputPosition instead.
        /// </summary>
        [JsonFormatter("{{ {0} }}")]
        public string InputBoxStyle
        {
            get;
            set;
        }

        /// <summary>
        /// The pixel width of the date input boxes. 
        /// Defaults to 90.
        /// </summary>
        public Number? InputBoxWidth
        {
            get;
            set;
        }

        /// <summary>
        /// A custom callback function to parse values entered in the input boxes and return a valid JavaScript time as milliseconds since 1970.
        /// </summary>
        [JsonFormatter("{0}")]
        public string InputDateParser
        {
            get;
            set;
        }

        /// <summary>
        /// The date format in the input boxes when they are selected for editing. This must be a format that is recognized by JavaScript Date.parse.
        /// Defaults to %Y-%m-%d.
        /// </summary>
        public string InputEditDateFormat
        {
            get;
            set;
        }

        /// <summary>
        /// Enable or disable the date input boxes.
        /// </summary>
        public bool? InputEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Positioning for the input boxes. Allowed properties are align, verticalAlign, x and y.
        /// Defaults to { align: "right" }.
        /// </summary>
        public Object InputPosition
        {
            get;
            set;
        }


        /// <summary>
        /// CSS for the HTML inputs in the range selector.
        /// </summary>
        [JsonFormatter("{{ {0} }}")]
        public string InputStyle
        {
            get;
            set;
        }
        
        /// <summary>
        /// CSS styles for the labels - the Zoom, From and To texts.
        /// </summary>
        [JsonFormatter("{{ {0} }}")]
        public string LabelStyle
        {
            get;
            set;
        }

        /// <summary>
        /// The index of the button to appear pre-selected. 
        /// Defaults to undefined.
        /// </summary>
        public Number? Selected
        {
            get;
            set;
        }
    }
}