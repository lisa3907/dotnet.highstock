using System;
using System.Drawing;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Options
{
	/// <summary>
	/// A wrapper object for all the series options in specific states.
	/// </summary>
	public class PlotOptionsSeriesStates
	{
		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public PlotOptionsSeriesStatesHover Hover { get; set; }

	}

}