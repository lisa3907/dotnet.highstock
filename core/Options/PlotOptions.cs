using System;
using Windows.UI;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	/// <summary>
	/// <p>The plotOptions is a wrapper object for config objects for each series type. The config objects for each series can also be overridden for each series  item as given in the series array.</p> <p>Configuration options for the series are given in three levels. Options for all series in a chart are given in the <a class='internal' href='#plotOptions.series'>plotOptions.series</a> object. Then options for all series of a specific type are given in the plotOptions of that type, for example plotOptions.line. Next, options for one single series are given in <a class='internal' href='#series'>the  series array</a>.</p>
	/// </summary>
	public class PlotOptions
	{
		public PlotOptionsArea Area { get; set; }

		/// <summary>
		/// The area range is a cartesian series type with higher and lower Y values along an X axis. Requires <code>highstock-more.js</code>.
		/// </summary>
		public PlotOptionsArearange Arearange { get; set; }

		public PlotOptionsAreaspline Areaspline { get; set; }

		/// <summary>
		/// The area spline range is a cartesian series type with higher and lower Y values along an X axis. Requires <code>highstock-more.js</code>.
		/// </summary>
		public PlotOptionsAreasplinerange Areasplinerange { get; set; }

		public PlotOptionsBar Bar { get; set; }

		/// <summary>
		/// A box plot is a convenient way of depicting groups of data through their five-number summaries: the smallest observation (sample minimum), lower quartile (Q1), median (Q2), upper quartile (Q3), and largest observation (sample maximum). 
		/// </summary>
		public PlotOptionsBoxplot Boxplot { get; set; }

		/// <summary>
		/// A bubble series is a three dimensional series type where each point renders an X, Y and Z value. Each points is drawn as a bubble where the position along the X and Y axes mark the X and Y values, and the size of the bubble relates to the Z value.
		/// </summary>
		public PlotOptionsBubble Bubble { get; set; }

		public PlotOptionsColumn Column { get; set; }

		/// <summary>
		/// The column range is a cartesian series type with higher and lower Y values along an X axis. Requires <code>highstock-more.js</code>. To display horizontal bars, set <a href='#chart.inverted'>chart.inverted</a> to <code>true</code>.
		/// </summary>
		public PlotOptionsColumnrange Columnrange { get; set; }

		/// <summary>
		/// Error bars are a graphical representation of the variability of data and are used on graphs to indicate the error, or uncertainty in a reported measurement. 
		/// </summary>
		public PlotOptionsErrorbar Errorbar { get; set; }

		/// <summary>
		/// Funnel charts are a type of chart often used to visualize stages in a sales project, where the top are the initial stages with the most clients. It requires that the <code>modules/funnel.js</code> file is loaded.
		/// </summary>
		public PlotOptionsFunnel Funnel { get; set; }

		/// <summary>
		/// General plotting options for the gauge series type. Requires <code>highstock-more.js</code>
		/// </summary>
		public PlotOptionsGauge Gauge { get; set; }

		/// <summary>
		/// The heatmap series type. This series type is available both in Highstock and Highmaps. See the <a href='http://api.highstock.com/highmaps#plotOptions.heatmap'>Highmaps API</a> for details.
		/// </summary>
		public Object Heatmap { get; set; }

		public PlotOptionsLine Line { get; set; }

		/// <summary>
		/// A pie chart is a circular chart divided into sectors, illustrating numerical proportion.
		/// </summary>
		public PlotOptionsPie Pie { get; set; }

		/// <summary>
		/// A pyramid chart consists of a single pyramid with item heights corresponding to each point value. Technically it is the same as a reversed funnel chart without a neck.
		/// </summary>
		public PlotOptionsPyramid Pyramid { get; set; }

		public PlotOptionsScatter Scatter { get; set; }

		/// <summary>
		/// <p>General options for all series types.</p>
		/// </summary>
		public PlotOptionsSeries Series { get; set; }

		/// <summary>
		/// A gauge showing values using a filled arc with colors indicating the value. The solid gauge plots values against the <code>yAxis</code>, which is extended with some color options, <a href='#yAxis.minColor'>minColor</a>, <a href='#yAxis.maxColor'>maxColor</a> and <a href='#yAxis.stops'>stops</a>, to control the color of the gauge itself.
		/// </summary>
		public PlotOptionsSolidgauge Solidgauge { get; set; }

		public PlotOptionsSpline Spline { get; set; }

		/// <summary>
		/// Options for the waterfall series type.
		/// </summary>
		public PlotOptionsWaterfall Waterfall { get; set; }

	}

}