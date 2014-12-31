using System;
using System.Drawing;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Options
{
	public class YAxisLabels
	{
		/// <summary>
		/// What part of the string the given position is anchored to.  Can be one of <code>'left'</code>, <code>'center'</code> or <code>'right'</code>.
		/// Default: right
		/// </summary>
		public HorizontalAligns? Align { get; set; }

		/// <summary>
		/// Enable or disable the axis labels.
		/// Default: true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// A <a href='http://www.highstock.com/docs/chart-concepts/labels-and-string-formatting'>format string</a> for the axis label. 
		/// Default: {value}
		/// </summary>
		public string Format { get; set; }

		/// <summary>
		/// Callback JavaScript function to format the label. The value is  given by <code>this.value</code>. Additional properties for <code>this</code> are <code>axis</code>, <code>chart</code>, <code>isFirst</code> and <code>isLast</code>. Defaults to: <pre>function() { return this.value;}</pre>
		/// </summary>
		[JsonFormatter("{0}")]
		public string Formatter { get; set; }

		/// <summary>
		/// Horizontal axis only. When <code>staggerLines</code> is not set, <code>maxStaggerLines</code> defines how many lines the axis is allowed to add to automatically avoid overlapping X labels. Set to <code>1</code> to disable overlap detection. 
		/// Default: 5
		/// </summary>
		public Number? MaxStaggerLines { get; set; }

		/// <summary>
		/// How to handle overflowing labels on horizontal axis. Can be undefined, <code>false</code> or <code>'justify'</code>. By default it aligns inside the chart area. If 'justify', labels will not render outside the plot area. If <code>false</code>, it will not be aligned at all. If there is room to move it, it will be aligned to the edge, else it will be removed.
		/// </summary>
		public string Overflow { get; set; }

		/// <summary>
		/// Rotation of the labels in degrees.
		/// Default: 0
		/// </summary>
		public Number? Rotation { get; set; }

		/// <summary>
		/// Horizontal axes only. The number of lines to spread the labels over to make room or tighter labels.  .
		/// </summary>
		public Number? StaggerLines { get; set; }

		/// <summary>
		/// <p>To show only every <em>n</em>'th label on the axis, set the step to <em>n</em>. Setting the step to 2 shows every other label.</p><p>By default, the step is calculated automatically to avoid overlap. To prevent this, set it to 1. This usually only happens on a category axis, and is often a sign that you have chosen the wrong axis type. Read more at <a href='http://www.highstock.com/docs/chart-concepts/axes'>Axis docs</a> => What axis should I use?</p> 
		/// </summary>
		public Number? Step { get; set; }

		/// <summary>
		/// CSS styles for the label. Use <code>whiteSpace: 'nowrap'</code> to prevent wrapping of category labels. Defaults to:<pre>style: { color: '#6D869F', fontWeight: 'bold'}</pre>
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// Whether to <a href='http://www.highstock.com/docs/chart-concepts/labels-and-string-formatting#html'>use HTML</a> to render the labels.
		/// Default: false
		/// </summary>
		public bool? UseHTML { get; set; }

		/// <summary>
		/// The x position offset of the label relative to the tick position on the axis. Defaults to -15 for left axis, 15 for right axis.
		/// </summary>
		public Number? X { get; set; }

		/// <summary>
		/// The y position offset of the label relative to the tick position on the axis.
		/// Default: 3
		/// </summary>
		public Number? Y { get; set; }

		/// <summary>
		/// The Z index for the axis labels.
		/// Default: 7
		/// </summary>
		public Number? ZIndex { get; set; }

		/// <summary>
		/// The distance of the data label from the pie's edge. Negative numbers put the data label on top of the pie slices. Connectors are only shown for data labels outside the pie.
		/// Default: 30
		/// </summary>
		public int? Distance { get; set; }
	}

}