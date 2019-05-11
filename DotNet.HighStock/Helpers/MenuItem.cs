using DotNet.HighStock.Attributes;

namespace DotNet.HighStock.Helpers
{
    public class MenuItem
    {
        /// <summary>
        /// String to show in the menu item
        /// </summary>
        public string Text
        {
            get; set;
        }

        /// <summary>
        /// Callback function to run on click.
        /// </summary>
        [JsonFormatter("{0}")]
        public string Onclick
        {
            get; set;
        }
    }
}