using System;
using Windows.UI;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	public class PlotOptionsSeriesMarker
	{
		/// <summary>
		/// Enable or disable the point marker.
		/// Default: true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// The fill color of the point marker. When <code>null</code>, the series' or point's color is used.
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
		/// The radius of the point marker.
		/// Default: 4
		/// </summary>
		public Number? Radius { get; set; }

		public PlotOptionsSeriesMarkerStates States { get; set; }

		/// <summary>
		/// <p>A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols. Other possible values are 'circle', 'square', 'diamond', 'triangle' and 'triangle-down'.</p><p>Additionally, the URL to a graphic can be given on this form:  'url(graphic.png)'. Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.</p><p>Custom callbacks for symbol path generation can also be added to <code>Highstock.SVGRenderer.prototype.symbols</code>. The callback is then used by its method name, as shown in the demo.</p>
		/// </summary>
		public string Symbol { get; set; }

	}

}