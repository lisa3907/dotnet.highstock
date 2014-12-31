using System;
using System.Drawing;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Options
{
	/// <summary>
	/// Options to render charts in 3 dimensions. This feature requires <code>highstock-3d.js</code>, found in the download package or online at <a href='http://code.highstock.com/highstock-3d.js'>code.highstock.com/highstock-3d.js</a>.
	/// </summary>
	public class ChartOptions3d
	{
		/// <summary>
		/// One of the two rotation angles for the chart.
		/// Default: 0
		/// </summary>
		public Number? Alpha { get; set; }

		/// <summary>
		/// One of the two rotation angles for the chart.
		/// Default: 0
		/// </summary>
		public Number? Beta { get; set; }

		/// <summary>
		/// The total depth of the chart.
		/// Default: 100
		/// </summary>
		public Number? Depth { get; set; }

		/// <summary>
		/// Wether to render the chart using the 3D functionality.
		/// Default: false
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Provides the option to draw a frame around the charts by defining a bottom, front and back panel. 
		/// </summary>
		public ChartOptions3dFrame Frame { get; set; }

		/// <summary>
		/// Defines the distance the viewer is standing in front of the chart, this setting is important to calculate the perspective effect in column and scatter charts.It is not used for 3D pie charts.
		/// Default: 100
		/// </summary>
		public Number? ViewDistance { get; set; }

	}

}