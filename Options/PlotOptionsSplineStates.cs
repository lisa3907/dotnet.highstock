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
	public class PlotOptionsSplineStates
	{
		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public PlotOptionsSplineStatesHover Hover { get; set; }

	}

}