using System;
using System.Drawing;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Options
{
	public class PlotOptionsBubbleMarkerStatesHover
	{
		/// <summary>
		/// Enable or disable the point marker.
		/// Default: true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// The fill color of the marker in hover state.
		/// </summary>
		public Color? FillColor { get; set; }

		/// <summary>
		/// The color of the point marker's outline. When <code>null</code>, the series' or point's color is used.
		/// Default: #FFFFFF
		/// </summary>
		public Color? LineColor { get; set; }

		/// <summary>
		/// The width of the point marker's outline.
		/// Default: 0
		/// </summary>
		public Number? LineWidth { get; set; }

		/// <summary>
		/// The additional line width for a hovered point.
		/// Default: 1
		/// </summary>
		public Number? LineWidthPlus { get; set; }

		/// <summary>
		/// The radius of the point marker. In hover state, it defaults to the normal state's radius + 2 as per the <a href='#plotOptions.series.marker.states.hover.radiusPlus'>radiusPlus</a> option.
		/// </summary>
		public Number? Radius { get; set; }

		/// <summary>
		/// The number of pixels to increase the radius of the hovered point.
		/// Default: 2
		/// </summary>
		public Number? RadiusPlus { get; set; }

	}

}