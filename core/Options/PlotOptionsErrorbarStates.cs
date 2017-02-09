using System;
using Windows.UI;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	/// <summary>
	/// A wrapper object for all the series options in specific states.
	/// </summary>
	public class PlotOptionsErrorbarStates
	{
		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public PlotOptionsErrorbarStatesHover Hover { get; set; }

	}

}