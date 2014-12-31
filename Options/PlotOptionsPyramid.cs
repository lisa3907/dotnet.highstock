using System;
using System.Drawing;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Options
{
	/// <summary>
	/// A pyramid chart consists of a single pyramid with item heights corresponding to each point value. Technically it is the same as a reversed funnel chart without a neck.
	/// </summary>
	public class PlotOptionsPyramid
	{
		/// <summary>
		/// Allow this series' points to be selected by clicking on the markers, bars or pie slices.
		/// Default: false
		/// </summary>
		public bool? AllowPointSelect { get; set; }

		/// <summary>
		/// The color of the border surrounding each slice.
		/// Default: #FFFFFF
		/// </summary>
		public Color? BorderColor { get; set; }

		/// <summary>
		/// The width of the border surrounding each slice.
		/// Default: 1
		/// </summary>
		public Number? BorderWidth { get; set; }

		/// <summary>
		/// The center of the funnel. By default, it is centered in the middle of the plot area, so it fills the plot area height.
		/// Default: ["50%", "50%"]
		/// </summary>
		public PercentageOrPixel[] Center { get; set; }

		/// <summary>
		/// A series specific or series type specific color set to use instead of the global <a href='#colors'>colors</a>.
		/// </summary>
		public Color[] Colors { get; set; }

		/// <summary>
		/// You can set the cursor to 'pointer' if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
		/// </summary>
		public Cursors? Cursor { get; set; }

		public PlotOptionsPyramidDataLabels DataLabels { get; set; }

		/// <summary>
		/// The thickness of a 3D pie. Requires <code>highstock-3d.js</code>
		/// Default: 0
		/// </summary>
		public Number? Depth { get; set; }

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
		/// Default: true
		/// </summary>
		public bool? EnableMouseTracking { get; set; }

		public PlotOptionsPyramidEvents Events { get; set; }

		/// <summary>
		/// The height of the funnel or pyramid. If it is a number it defines the pixel height, if it is a percentage string it is the percentage of the plot area height.
		/// </summary>
		[JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
		public PercentageOrPixel Height { get; set; }

		/// <summary>
		/// <p>Equivalent to <a href='#chart.ignoreHiddenSeries'>chart.ignoreHiddenSeries</a>, this option tells whether the series shall be redrawn as if the hidden point were <code>null</code>.</p><p>The default value changed from <code>false</code> to <code>true</code> with Highstock 3.0.</p>
		/// Default: true
		/// </summary>
		public bool? IgnoreHiddenPoint { get; set; }

		/// <summary>
		/// The <a href='#series.id'>id</a> of another series to link to. Additionally, the value can be ':previous' to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }

		/// <summary>
		/// The minimum size for a pie in response to auto margins. The pie will try to shrink to make room for data labels in side the plot area, but only to this size.
		/// Default: 80
		/// </summary>
		public Number? MinSize { get; set; }

		/// <summary>
		/// Properties for each single point
		/// </summary>
		public PlotOptionsPyramidPoint Point { get; set; }

		/// <summary>
		/// The pyramid is reversed by default, as opposed to the funnel, which shares the layout engine, and is not reversed.
		/// Default: true
		/// </summary>
		public bool? Reversed { get; set; }

		/// <summary>
		/// Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name will be checked for a selected series.
		/// Default: false
		/// </summary>
		public bool? Selected { get; set; }

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// Default: false
		/// </summary>
		public bool? Shadow { get; set; }

		/// <summary>
		/// Whether to display this particular series or series type in the legend. Since 2.1, pies are not shown in the legend by default.
		/// Default: false
		/// </summary>
		public bool? ShowInLegend { get; set; }

		/// <summary>
		/// If a point is sliced, moved out from the center, how many pixels should  it be moved?.
		/// Default: 10
		/// </summary>
		public Number? SlicedOffset { get; set; }

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsPyramidStates States { get; set; }

		/// <summary>
		/// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series.
		/// Default: false
		/// </summary>
		public bool? StickyTracking { get; set; }

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href='#tooltip'>tooltip</a>, but only the following properties can be defined on a series level.
		/// </summary>
		public PlotOptionsPyramidTooltip Tooltip { get; set; }

		/// <summary>
		/// Set the initial visibility of the series.
		/// Default: true
		/// </summary>
		public bool? Visible { get; set; }

		/// <summary>
		/// The width of the funnel compared to the width of the plot area, or the pixel width if it is a number.
		/// Default: 90%
		/// </summary>
		[JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
		public PercentageOrPixel Width { get; set; }

	}

}