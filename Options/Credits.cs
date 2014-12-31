using System;
using System.Drawing;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Options
{
    /// <summary>
    /// Highchart by default puts a credits label in the lower right corner of the chart. This can be changed using these options.
    /// </summary>
    public class Credits
    {
        /// <summary>
        /// Whether to show the credits text.
        /// Default: true
        /// </summary>
        public bool? Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// The URL for the credits label.
        /// Default: http://www.highstock.com
        /// </summary>
        public string Href
        {
            get;
            set;
        }

        /// <summary>
        /// Position configuration for the credits label. Supported properties are  <code>align</code>, <code>verticalAlign</code>, <code>x</code> and <code>y</code>. Defaults to <pre>position: { align: 'right', x: -10, verticalAlign: 'bottom', y: -5}</pre>
        /// </summary>
        public Position Position
        {
            get;
            set;
        }

        /// <summary>
        /// CSS styles for the credits label. Defaults to:<pre>style: { cursor: 'pointer', color: '#909090', fontSize: '10px'}</pre>
        /// </summary>
        [JsonFormatter("{{ {0} }}")]
        public string Style
        {
            get;
            set;
        }

        /// <summary>
        /// The text for the credits label.
        /// Default: Highstock.com
        /// </summary>
        public string Text
        {
            get;
            set;
        }

    }
}