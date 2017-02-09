using System;
using Windows.UI;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	/// <summary>
	/// Options for the hovered series
	/// </summary>
	public class PlotOptionsArearangeStatesHover
	{
		/// <summary>
		/// Enable separate styles for the hovered series to visualize that the user hovers either the series itself or the legend..
		/// Default: true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Options for the halo appearing around the hovered point in line-type series as well as outside the hovered slice in pie charts. By default the halo is filled by the current point or series color with an opacity of 0.25. The halo can be disabled by setting the <code>halo</code> option to <code>false</code>.
		/// </summary>
		public PlotOptionsArearangeStatesHoverHalo Halo { get; set; }

		/// <summary>
		/// Pixel with of the graph line.
		/// Default: 2
		/// </summary>
		public Number? LineWidth { get; set; }

		/// <summary>
		/// The additional line width for the graph of a hovered series.
		/// Default: 1
		/// </summary>
		public Number? LineWidthPlus { get; set; }

		public PlotOptionsArearangeStatesHoverMarker Marker { get; set; }

	}

}