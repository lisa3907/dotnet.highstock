namespace DotNet.HighStock.Options
{
    /// <summary>
    /// A wrapper object for all the series options in specific states.
    /// </summary>
    public class PlotOptionsBarStates
    {
        /// <summary>
        /// Options for the hovered series
        /// </summary>
        public PlotOptionsBarStatesHover Hover
        {
            get; set;
        }
    }
}