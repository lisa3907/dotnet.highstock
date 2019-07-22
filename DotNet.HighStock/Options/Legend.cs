using DotNet.HighStock.Attributes;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Helpers;
using System;
using System.Drawing;

namespace DotNet.HighStock.Options
{
    /// <summary>
    /// The legend is a box containing a symbol and name for each series item or point item in the chart.
    /// </summary>
    public class Legend
    {
        /// <summary>
        /// The horizontal alignment of the legend box within the chart area. Valid values are <code>'left'</code>, <code>'center'</code> and <code>'right'</code>.
        /// Default: center
        /// </summary>
        public HorizontalAligns? Align
        {
            get;
            set;
        }

        /// <summary>
        /// The background color of the legend.
        /// </summary>
        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public BackColorOrGradient BackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// The color of the drawn border around the legend.
        /// Default: #909090
        /// </summary>
        public Color? BorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// The border corner radius of the legend.
        /// Default: 0
        /// </summary>
        public Number? BorderRadius
        {
            get;
            set;
        }

        /// <summary>
        /// The width of the drawn border around the legend.
        /// Default: 0
        /// </summary>
        public Number? BorderWidth
        {
            get;
            set;
        }

        /// <summary>
        /// Enable or disable the legend.
        /// Default: true
        /// </summary>
        public bool? Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// When the legend is floating, the plot area ignores it and is allowed to be placed below it.
        /// Default: false
        /// </summary>
        public bool? Floating
        {
            get;
            set;
        }

        /// <summary>
        /// In a legend with horizontal layout, the itemDistance defines the pixel distance between each item.
        /// Default: 20
        /// </summary>
        public Number? ItemDistance
        {
            get;
            set;
        }

        /// <summary>
        /// CSS styles for each legend item when the corresponding series or point is hidden. Only a subset of CSS is supported, notably those options related to text. Properties are inherited from <code>style</code> unless overridden here. Defaults to:<pre>itemHiddenStyle: { color: '#CCC'}</pre>
        /// </summary>
        [JsonFormatter("{{ {0} }}")]
        public string ItemHiddenStyle
        {
            get;
            set;
        }

        /// <summary>
        /// CSS styles for each legend item in hover mode. Only a subset of CSS is supported, notably those options related to text. Properties are inherited from <code>style</code> unless overridden here. Defaults to:<pre>itemHoverStyle: { color: '#000'}</pre>
        /// </summary>
        [JsonFormatter("{{ {0} }}")]
        public string ItemHoverStyle
        {
            get;
            set;
        }

        /// <summary>
        /// The pixel bottom margin for each legend item.
        /// Default: 0
        /// </summary>
        public Number? ItemMarginBottom
        {
            get;
            set;
        }

        /// <summary>
        /// The pixel top margin for each legend item.
        /// Default: 0
        /// </summary>
        public Number? ItemMarginTop
        {
            get;
            set;
        }

        /// <summary>
        /// CSS styles for each legend item. Only a subset of CSS is supported, notably those options related to text.
        /// Default: { "color": "#333333", "cursor": "pointer", "fontSize": "12px", "fontWeight": "bold" }
        /// </summary>
        [JsonFormatter("{{ {0} }}")]
        public string ItemStyle
        {
            get;
            set;
        }

        /// <summary>
        /// The width for each legend item. This is useful in a horizontal layout with many items when you want the items to align vertically.  .
        /// </summary>
        public Number? ItemWidth
        {
            get;
            set;
        }

        /// <summary>
        /// A <a href='http://www.highstock.com/docs/chart-concepts/labels-and-string-formatting'>format string</a> for each legend label. Available variables relates to properties on the series, or the point in case of pies.
        /// Default: {name}
        /// </summary>
        public string LabelFormat
        {
            get;
            set;
        }

        /// <summary>
        /// Callback function to format each of the series' labels. The <em>this</em> keyword refers to the series object, or the point object in case of pie charts. By default the series or point name is printed.
        /// </summary>
        [JsonFormatter("{0}")]
        public string LabelFormatter
        {
            get;
            set;
        }

        /// <summary>
        /// The layout of the legend items. Can be one of 'horizontal' or 'vertical'.
        /// Default: horizontal
        /// </summary>
        public Layouts? Layout
        {
            get;
            set;
        }

        /// <summary>
        /// Line height for the legend items. Deprecated as of 2.1. Instead, the line height for each  item can be set using itemStyle.lineHeight, and the padding between items using itemMarginTop and itemMarginBottom.
        /// Default: 16
        /// </summary>
        public Number? LineHeight
        {
            get;
            set;
        }

        /// <summary>
        /// If the plot area sized is calculated automatically and the legend is not floating, the legend margin is the  space between the legend and the axis labels or plot area.
        /// Default: 15
        /// </summary>
        public Number? Margin
        {
            get;
            set;
        }

        /// <summary>
        /// Maximum pixel height for the legend. When the maximum height is extended, navigation will show.
        /// </summary>
        public Number? MaxHeight
        {
            get;
            set;
        }

        /// <summary>
        /// Options for the paging or navigation appearing when the legend is overflown. When <a href='#legend.useHTML'>legend.useHTML</a> is enabled, navigation is disabled.
        /// </summary>
        public LegendNavigation Navigation
        {
            get;
            set;
        }

        /// <summary>
        /// The inner padding of the legend box.
        /// Default: 8
        /// </summary>
        public Number? Padding
        {
            get;
            set;
        }

        /// <summary>
        /// Whether to reverse the order of the legend items compared to the order of the series or points as defined in the configuration object.
        /// Default: false
        /// </summary>
        public bool? Reversed
        {
            get;
            set;
        }

        /// <summary>
        /// Whether to show the symbol on the right side of the text rather than the left side.  This is common in Arabic and Hebraic.
        /// Default: false
        /// </summary>
        public bool? Rtl
        {
            get;
            set;
        }

        /// <summary>
        /// Whether to apply a drop shadow to the legend. A <code>backgroundColor</code> also needs to be applied for this to take effect. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
        /// Default: false
        /// </summary>
        public bool? Shadow
        {
            get;
            set;
        }

        [Obsolete("CSS styles for the legend area. In the 1.x versions the position of the legend area was determined by CSS. In 2.x, the position is determined by properties like  <code>align</code>, <code>verticalAlign</code>, <code>x</code> and <code>y</code>, but the styles are still parsed for backwards compatibility.")]
        [JsonFormatter("{{ {0} }}")]
        public string Style
        {
            get;
            set;
        }

        /// <summary>
        /// The pixel height of the symbol for series types that use a rectangle in the legend.
        /// Default: 12
        /// </summary>
        public Number? SymbolHeight
        {
            get;
            set;
        }

        /// <summary>
        /// The pixel padding between the legend item symbol and the legend item text.
        /// Default: 5
        /// </summary>
        public Number? SymbolPadding
        {
            get;
            set;
        }

        /// <summary>
        /// The border radius of the symbol for series types that use a rectangle in the legend.
        /// Default: 2
        /// </summary>
        public Number? SymbolRadius
        {
            get;
            set;
        }

        /// <summary>
        /// The pixel width of the legend item symbol.
        /// Default: 16
        /// </summary>
        public Number? SymbolWidth
        {
            get;
            set;
        }

        /// <summary>
        /// A title to be added on top of the legend.
        /// </summary>
        public LegendTitle Title
        {
            get;
            set;
        }

        /// <summary>
        /// <p>Whether to <a href='http://www.highstock.com/docs/chart-concepts/labels-and-string-formatting#html'>use HTML</a> to render the legend item texts. When using HTML, <a href='#legend.navigation'>legend.navigation</a> is disabled.</p>
        /// Default: false
        /// </summary>
        public bool? UseHTML
        {
            get;
            set;
        }

        /// <summary>
        /// The vertical alignment of the legend box. Can be one of 'top', 'middle' or  'bottom'. Vertical position can be further determined by the <code>y</code> option.
        /// Default: bottom
        /// </summary>
        public VerticalAligns? VerticalAlign
        {
            get;
            set;
        }

        /// <summary>
        /// The width of the legend box.
        /// </summary>
        public Number? Width
        {
            get;
            set;
        }

        /// <summary>
        /// The x offset of the legend relative to its horizontal alignment <code>align</code> within chart.spacingLeft and chart.spacingRight. Negative x moves it to the left, positive x moves it to the right.
        /// Default: 0
        /// </summary>
        public Number? X
        {
            get;
            set;
        }

        /// <summary>
        /// The vertical offset of the legend relative to it's vertical alignment <code>verticalAlign</code> within chart.spacingTop and chart.spacingBottom. Negative y moves it up, positive y moves it down.
        /// Default: 0
        /// </summary>
        public Number? Y
        {
            get;
            set;
        }
    }
}