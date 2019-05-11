using DotNet.HighStock.Options;
using System.Drawing;

namespace DotNet.HighStock.Helpers
{
    public class GlobalOptions
    {
        /// <summary>
        /// Global options that don't apply to each chart. These options, like the lang options, must be set using the Highstock.setOptions method.
        /// </summary>
        /// <see cref="http://api.highcharts.com/highstock#global"/>
        public Global Global
        {
            get;
            set;
        }

        /// <summary>
        /// An array containing the default colors for the chart's series. When all colors are used, new colors are pulled from the start again.
        /// Defaults to:
        /// <code>
        /// colors: ['#4572A7', '#AA4643', '#89A54E', '#80699B', '#3D96AE', '#DB843D', '#92A8CD', '#A47D7C', '#B5CA92']
        /// </code>
        /// </summary>
        /// <see cref="http://api.highcharts.com/highstock#colors"/>
        public Color[] Colors
        {
            get;
            set;
        }

        /// <summary>
        /// Language object. The language object is global and it can't be set on each chart initiation.
        /// Instead, use Highstock.setOptions to set it before any chart is initiated.
        /// </summary>
        /// <see cref="http://api.highcharts.com/highstock#lang"/>
        public Lang Lang
        {
            get;
            set;
        }
    }
}