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
	public class PlotOptionsWaterfallStates
	{
		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public PlotOptionsWaterfallStatesHover Hover { get; set; }

	}

}