using System;
using System.Drawing;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Options
{
	/// <summary>
	/// Options for the export related buttons, print and export. In addition to the default buttons listed here, custom buttons can be added. See <a href='#navigation.buttonOptions'>navigation.buttonOptions</a> for general options.
	/// </summary>
	public class ExportingButtons
	{
		/// <summary>
		/// Options for the export button.
		/// </summary>
		public ExportingButtonsContextButton ContextButton { get; set; }

	}

}