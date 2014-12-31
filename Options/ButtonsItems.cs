using System;
using System.Drawing;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Options
{
    /// <summary>
    /// 
    /// </summary>
    public class ButtonsItems
    {
        /// <summary>
        /// Defines the timespan, can be one of 'millisecond', 'second', 'minute', 'day', 'week', 'month', 'ytd' (year to date), 'year' and 'all'.
        /// </summary>
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// Defines how many units of the defined type to use.
        /// </summary>
        public Number? Count
        {
            get;
            set;
        }

        /// <summary>
        /// The text for the button itself
        /// </summary>
        public string Text
        {
            get;
            set;
        }

    }
}