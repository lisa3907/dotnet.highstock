using System;
using Windows.UI;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
    /// <summary>
    /// Global options that don't apply to each chart. These options, like the <code>lang</code> options, must be set using the <code>Highstock.setOptions</code> method.<pre>Highstock.setOptions({ global: { useUTC: false }});</pre>
    /// </summary>
    public class Global
    {
        /// <summary>
        /// Path to the pattern image required by VML browsers in order to draw radial gradients.
        /// Default: http://code.highstock.com/{version}/gfx/vml-radial-gradient.png
        /// </summary>
        public string VMLRadialGradientURL
        {
            get;
            set;
        }

        /// <summary>
        /// The timezone offset in minutes. Positive values are west, negative values are east of UTC, as in the ECMAScript <a href='https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/getTimezoneOffset'>getTimezoneOffset</a> method. Use this to display UTC based data in a predefined time zone. 
        /// Default: 0
        /// </summary>
        public Number? TimezoneOffset
        {
            get;
            set;
        }

        /// <summary>
        /// Whether to use UTC time for axis scaling, tickmark placement and time display in  <code>Highstock.dateFormat</code>. Advantages of using UTC is that the time displays equally regardless of the user agent's time zone settings. Local time can be used when the data is loaded in real time or when correct Daylight Saving Time transitions are required.
        /// Default: true
        /// </summary>
        public bool? UseUTC
        {
            get;
            set;
        }

    }
}