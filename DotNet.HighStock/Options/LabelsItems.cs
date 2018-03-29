using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
    /// <summary>
    /// A HTML label that can be positioned anywhere in the chart area.
    /// </summary>
    public class LabelsItems
    {
        /// <summary>
        /// Inner HTML or text for the label.
        /// </summary>
        public string Html
        {
            get;
            set;
        }

        /// <summary>
        /// CSS styles for each label. To position the label, use left and top like this:<pre>style: { left: '100px', top: '100px'}</pre>
        /// </summary>
        [JsonFormatter("{{ {0} }}")]
        public string Style
        {
            get;
            set;
        }

    }
}