using System;
using System.Drawing;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Options
{
	/// <summary>
	/// Properties for each single point
	/// </summary>
	public class PlotOptionsSeriesPoint
	{
		/// <summary>
		/// Events for each single point
		/// </summary>
		public PlotOptionsSeriesPointEvents Events { get; set; }

	}

}