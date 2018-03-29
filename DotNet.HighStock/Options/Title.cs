using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	/// <summary>
	/// The chart's main title.
	/// </summary>
	public class Title
	{
		/// <summary>
		/// The horizontal alignment of the title. Can be one of 'left', 'center' and 'right'.
		/// Default: center
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// When the title is floating, the plot area will not move to make space for it.
		/// Default: false
		/// </summary>
		public bool? Floating { get; set; }

		/// <summary>
		/// The margin between the title and the plot area, or if a subtitle is present, the margin between the subtitle and the plot area.
		/// Default: 15
		/// </summary>
		public Number? Margin { get; set; }

		/// <summary>
		/// CSS styles for the title. Use this for font styling, but use <code>align</code>, <code>x</code> and <code>y</code> for text alignment.
		/// Default: { "color": "#333333", "fontSize": "18px" }
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// The title of the chart. To disable the title, set the <code>text</code> to <code>null</code>.
		/// Default: Chart title
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// Whether to <a href='http://www.highstock.com/docs/chart-concepts/labels-and-string-formatting#html'>use HTML</a> to render the text.
		/// Default: false
		/// </summary>
		public bool? UseHTML { get; set; }

		/// <summary>
		/// The vertical alignment of the title. Can be one of 'top', 'middle' and 'bottom'. When a value is given, the title behaves as floating.
		/// Default:  
		/// </summary>
		public VerticalAligns? VerticalAlign { get; set; }

		/// <summary>
		/// The x position of the title relative to the alignment within chart.spacingLeft and chart.spacingRight.
		/// Default: 0
		/// </summary>
		public Number? X { get; set; }

		/// <summary>
		/// The y position of the title relative to the alignment within <a href='#chart.spacingTop'>chart.spacingTop</a> and <a href='#chart.spacingBottom'>chart.spacingBottom</a>. By default it depends on the font size.
		/// </summary>
		public Number? Y { get; set; }

	}

}