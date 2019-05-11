namespace DotNet.HighStock.Options
{
    /// <summary>
    /// A wrapper object for all the series options in specific states.
    /// </summary>
    public class PlotOptionsLineStates
    {
        /// <summary>
        /// Options for the hovered series
        /// </summary>
        public PlotOptionsLineStatesHover Hover
        {
            get; set;
        }
    }
}