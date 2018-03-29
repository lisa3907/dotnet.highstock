using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	/// <summary>
	/// Options for the halo appearing around the hovered point in line-type series as well as outside the hovered slice in pie charts. By default the halo is filled by the current point or series color with an opacity of 0.25. The halo can be disabled by setting the <code>halo</code> option to <code>false</code>.
	/// </summary>
	public class PlotOptionsAreasplinerangeStatesHoverHalo
	{
		/// <summary>
		/// A collection of SVG attributes to override the appearance of the halo, for example <code>fill</code>, <code>stroke</code> and <code>stroke-width</code>.
		/// </summary>
		public Object Attributes { get; set; }

		/// <summary>
		/// Opacity for the halo unless a specific fill is overridden using the <code>attributes</code> setting. Note that Highstock is only able to apply opacity to colors of hex or rgb(a) formats.
		/// Default: 0.25
		/// </summary>
		public Number? Opacity { get; set; }

		/// <summary>
		/// The pixel size of the halo. For point markers this is the radius of the halo. For pie slices it is the width of the halo outside the slice. For bubbles it defaults to 5 and is the width of the halo outside the bubble.
		/// Default: 10
		/// </summary>
		public Number? Size { get; set; }

	}

}