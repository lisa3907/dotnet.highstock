using System;
using System.Drawing;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Options
{
    /// <summary>
    /// HTML labels that can be positioned anywhere in the chart area.
    /// </summary>
    public class Labels
    {
        /// <summary>
        /// A HTML label that can be positioned anywhere in the chart area.
        /// </summary>
        public LabelsItems[] Items
        {
            get;
            set;
        }

        /// <summary>
        /// Shared CSS styles for all labels. Defaults to:<pre>style: { color: '#3E576F'}</pre>
        /// </summary>
        [JsonFormatter("{{ {0} }}")]
        public string Style
        {
            get;
            set;
        }

    }

}