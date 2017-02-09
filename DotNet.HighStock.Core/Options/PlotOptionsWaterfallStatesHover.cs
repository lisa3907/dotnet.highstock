using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	/// <summary>
	/// Options for the hovered series
	/// </summary>
	public class PlotOptionsWaterfallStatesHover
	{
		/// <summary>
		/// How much to brighten the point on interaction. Requires the main color to be defined in hex or rgb(a) format.
		/// Default: 0.1
		/// </summary>
		public Number? Brightness { get; set; }

		/// <summary>
		/// Enable separate styles for the hovered series to visualize that the user hovers either the series itself or the legend..
		/// Default: true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Options for the halo appearing around the hovered point in line-type series as well as outside the hovered slice in pie charts. By default the halo is filled by the current point or series color with an opacity of 0.25. The halo can be disabled by setting the <code>halo</code> option to <code>false</code>.
		/// </summary>
		public PlotOptionsWaterfallStatesHoverHalo Halo { get; set; }

	}

}