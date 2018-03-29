using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	/// <summary>
	/// Properties for each single point
	/// </summary>
	public class PlotOptionsBarPoint
	{
		/// <summary>
		/// Events for each single point
		/// </summary>
		public PlotOptionsBarPointEvents Events { get; set; }

	}

}