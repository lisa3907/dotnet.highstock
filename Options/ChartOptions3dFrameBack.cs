using System;
using System.Drawing;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Options
{
	/// <summary>
	/// Defines the back panel of the frame around 3D charts.
	/// </summary>
	public class ChartOptions3dFrameBack
	{
		/// <summary>
		/// The color of the panel.
		/// Default: transparent
		/// </summary>
		public Color? Color { get; set; }

		/// <summary>
		/// Thickness of the panel.
		/// Default: 1
		/// </summary>
		public Number? Size { get; set; }

	}

}