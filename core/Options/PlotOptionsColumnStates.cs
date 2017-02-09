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
	public class PlotOptionsColumnStates
	{
		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public PlotOptionsColumnStatesHover Hover { get; set; }

	}

}