using System;
using Windows.UI;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	/// <summary>
	/// Properties for each single point
	/// </summary>
	public class PlotOptionsSolidgaugePoint
	{
		/// <summary>
		/// Events for each single point
		/// </summary>
		public PlotOptionsSolidgaugePointEvents Events { get; set; }

	}

}