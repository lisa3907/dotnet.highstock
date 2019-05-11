using DotNet.HighStock.Helpers;
using DotNet.HighStock.Options;
using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.HighStock
{
    public class HighStock : HtmlString
    {
        internal string Name
        {
            get;
            private set;
        }

        internal string ContainerName
        {
            get;
            private set;
        }

        internal IDictionary<string, string> JsVariables
        {
            get;
            private set;
        }

        internal IDictionary<string, string> JsFunctions
        {
            get;
            private set;
        }

        internal GlobalOptions Options
        {
            get;
            private set;
        }

        internal string FunctionName
        {
            get;
            private set;
        }

        private Chart chart
        {
            get; set;
        }

        private Credits credits
        {
            get; set;
        }

        private Exporting exporting
        {
            get; set;
        }

        private Labels labels
        {
            get; set;
        }

        private Legend legend
        {
            get; set;
        }

        private Loading loading
        {
            get; set;
        }

        private Navigation navigation
        {
            get; set;
        }

        private Navigator navigator
        {
            get; set;
        }

        private PlotOptions plotOptions
        {
            get; set;
        }

        private RangeSelector rangeSelector
        {
            get; set;
        }

        private Scrollbar scrollbar
        {
            get; set;
        }

        private Series series
        {
            get; set;
        }

        private Series[] seriesArray
        {
            get; set;
        }

        private Subtitle subtitle
        {
            get; set;
        }

        private Title title
        {
            get; set;
        }

        private Tooltip tooltip
        {
            get; set;
        }

        private XAxis xAxis
        {
            get; set;
        }

        private XAxis[] xAxisArray
        {
            get; set;
        }

        private YAxis yAxis
        {
            get; set;
        }

        private YAxis[] yAxisArray
        {
            get; set;
        }

        /// <summary>
        /// The chart object is the JavaScript object representing a single chart in the web page.
        /// </summary>
        /// <param name="name">The object name of the chart and related container</param>
        /// <see cref="http://api.highcharts.com/highstock"/>
        public HighStock(string name)
            : base(name)
        {
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The name of the chart must be specified.");

            Name = name;
            ContainerName = "{0}_container".FormatWith(name);
            JsVariables = new Dictionary<string, string>();
            JsFunctions = new Dictionary<string, string>();
        }

        /// <summary>
        /// Global options that don't apply to each chart. These options, like the lang options, must be set using the Highstock.setOptions method.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HighStock SetOptions(GlobalOptions options)
        {
            Options = options;
            return this;
        }

        /// <summary>
        /// Options regarding the chart area and plot area as well as general chart options.
        /// </summary>
        /// <param name="chart"></param>
        /// <returns></returns>
        public HighStock InitChart(Chart chart)
        {
            this.chart = chart;
            return this;
        }

        /// <summary>
        /// Highchart by default puts a credits label in the lower right corner of the chart.
        /// This can be changed using these options.
        /// </summary>
        public HighStock SetCredits(Credits credits)
        {
            this.credits = credits;
            return this;
        }

        /// <summary>
        /// Options for the exporting module.
        /// </summary>
        /// <param name="exporting"></param>
        /// <returns></returns>
        public HighStock SetExporting(Exporting exporting)
        {
            this.exporting = exporting;
            return this;
        }

        /// <summary>
        /// HTML labels that can be positioined anywhere in the chart area.
        /// </summary>
        /// <param name="labels"></param>
        /// <returns></returns>
        public HighStock SetLabels(Labels labels)
        {
            this.labels = labels;
            return this;
        }

        /// <summary>
        /// The legend is a box containing a symbol and name for each series item or point item in the chart.
        /// </summary>
        /// <param name="legend"></param>
        /// <returns></returns>
        public HighStock SetLegend(Legend legend)
        {
            this.legend = legend;
            return this;
        }

        /// <summary>
        /// The loading options control the appearance of the loading screen that covers the plot area on chart operations.
        /// This screen only appears after an explicit call to chart.showLoading(). It is a utility for developers to
        /// communicate to the end user that something is going on, for example while retrieving new data via an XHR connection.
        /// The "Loading..." text itself is not part of this configuration object, but part of the lang object.
        /// </summary>
        /// <param name="loading"></param>
        /// <returns></returns>
        public HighStock SetLoading(Loading loading)
        {
            this.loading = loading;
            return this;
        }

        /// <summary>
        /// A collection of options for buttons and menus appearing in the exporting module.
        /// </summary>
        /// <param name="navigation"></param>
        /// <returns></returns>
        public HighStock SetNavigation(Navigation navigation)
        {
            this.navigation = navigation;
            return this;
        }

        /// <summary>
        /// The navigator is a small series below the main series, displaying a view of the entire data set.
        /// It provides tools to zoom in and out on parts of the data as well as panning across the dataset.
        /// </summary>
        /// <param name="navigator"></param>
        /// <returns></returns>
        public HighStock SetNavigator(Navigator navigator)
        {
            this.navigator = navigator;
            return this;
        }

        /// <summary>
        /// The plotOptions is a wrapper object for config objects for each series type. The config objects for each series
        /// can also be overridden for each series item as given in the series array.
        /// Configuration options for the series are given in three levels. Options for all series in a chart are given in
        /// the plotOptions.series object. Then options for all series of a specific type are given in the plotOptions of
        /// that type, for example plotOptions.line. Next, options for one single series are given in the series array.
        /// </summary>
        /// <param name="plotOptions"></param>
        /// <returns></returns>
        public HighStock SetPlotOptions(PlotOptions plotOptions)
        {
            this.plotOptions = plotOptions;
            return this;
        }

        /// <summary>
        /// The range selector is a tool for selecting ranges to display within the chart.
        /// It provides buttons to select preconfigured ranges in the chart, like 1 day, 1 week, 1 month etc.
        /// It also provides input boxes where min and max dates can be manually input.
        /// </summary>
        /// <param name="rangeSelector"></param>
        /// <returns></returns>
        public HighStock SetRangeSelector(RangeSelector rangeSelector)
        {
            this.rangeSelector = rangeSelector;
            return this;
        }

        /// <summary>
        /// The scrollbar is a means of panning over the X axis of a chart.
        /// </summary>
        /// <param name="scrollbar"></param>
        /// <returns></returns>
        public HighStock SetScrollbar(Scrollbar scrollbar)
        {
            this.scrollbar = scrollbar;
            return this;
        }

        /// <summary>
        /// The actual series to append to the chart. In addition to the members listed below, any member of the plotOptions
        /// for that specific type of plot can be added to a series individually. For example, even though a general lineWidth
        /// is specified in plotOptions.series, an individual lineWidth can be specified for each series.
        /// </summary>
        /// <param name="series"></param>
        /// <returns></returns>
        public HighStock SetSeries(Series series)
        {
            this.series = series;
            return this;
        }

        /// <summary>
        /// The actual series to append to the chart. In addition to the members listed below, any member of the plotOptions
        /// for that specific type of plot can be added to a series individually. For example, even though a general lineWidth
        /// is specified in plotOptions.series, an individual lineWidth can be specified for each series.
        /// </summary>
        /// <param name="seriesArray">Array of series options.</param>
        /// <returns></returns>
        public HighStock SetSeries(Series[] seriesArray)
        {
            this.seriesArray = seriesArray;
            return this;
        }

        /// <summary>
        /// The chart's subtitle
        /// </summary>
        /// <param name="subtitle">The subtitle options.</param>
        /// <returns></returns>
        public HighStock SetSubtitle(Subtitle subtitle)
        {
            this.subtitle = subtitle;
            return this;
        }

        /// <summary>
        /// The chart's main title.
        /// </summary>
        /// <param name="title">The title options.</param>
        /// <returns></returns>
        public HighStock SetTitle(Title title)
        {
            this.title = title;
            return this;
        }

        /// <summary>
        /// Options for the tooltip that appears when the user hovers over a series or point.
        /// </summary>
        /// <param name="tooltip">The tooltip options.</param>
        /// <returns></returns>
        public HighStock SetTooltip(Tooltip tooltip)
        {
            this.tooltip = tooltip;
            return this;
        }

        /// <summary>
        /// The X axis or category axis. Normally this is the horizontal axis, though if the chart is inverted this is the vertical axis.
        /// In case of multiple axes, the xAxis node is an array of configuration objects.
        /// </summary>
        /// <param name="xAxis">The X axis options.</param>
        /// <returns></returns>
        public HighStock SetXAxis(XAxis xAxis)
        {
            this.xAxis = xAxis;
            return this;
        }

        /// <summary>
        /// The X axis or category axis. Normally this is the horizontal axis, though if the chart is inverted this is the vertical axis.
        /// In case of multiple axes, the xAxis node is an array of configuration objects.
        /// </summary>
        /// <param name="xAxisArray">Array of X axis options.</param>
        /// <returns></returns>
        public HighStock SetXAxis(XAxis[] xAxisArray)
        {
            this.xAxisArray = xAxisArray;
            return this;
        }

        /// <summary>
        /// The Y axis or value axis. Normally this is the vertical axis, though if the chart is inverted this is the horiontal axis.
        /// In case of multiple axes, the yAxis node is an array of configuration objects.
        /// </summary>
        /// <param name="yAxis">The Y axis options.</param>
        /// <returns></returns>
        public HighStock SetYAxis(YAxis yAxis)
        {
            this.yAxis = yAxis;
            return this;
        }

        /// <summary>
        /// Sets the y axis.
        /// </summary>
        /// <param name="yAxisArray">Array Y axis options.</param>
        /// <returns></returns>
        public HighStock SetYAxis(YAxis[] yAxisArray)
        {
            this.yAxisArray = yAxisArray;
            return this;
        }

        /// <summary>
        /// Add the javascript variable to the same jQuery document ready where chart is initialized.
        /// Variables are added before the chart.
        /// </summary>
        /// <param name="name">The name of the variable.</param>
        /// <param name="value">The value of the variable.</param>
        /// <returns></returns>
        public HighStock AddJavascripVariable(string name, string value)
        {
            JsVariables.Add(name, value);
            return this;
        }

        /// <summary>
        /// Add javascript function to the same jQuery document ready where chart is initialized.
        /// The functions are added after the chart.
        /// </summary>
        /// <param name="name">The name of the function.</param>
        /// <param name="body">The body of the function.</param>
        /// <param name="variables">The variables of the function.</param>
        /// <returns></returns>
        public HighStock AddJavascripFunction(string name, string body, params string[] variables)
        {
            JsFunctions.Add("function {0}({1}){{".FormatWith(name, String.Join(", ", variables)), body);
            return this;
        }

        public HighStock InFunction(string name)
        {
            FunctionName = name;
            return this;
        }

        /// <summary>
        /// Returns DIV element for the chart in an HTML-encoded String.
        /// </summary>
        /// <returns></returns>
        public HtmlString ChartContainerHtmlString()
        {
            return new HtmlString("<div id='{0}'></div>".FormatWith(ContainerName));
        }

        /// <summary>
        /// Returns JavaScript code for the chart in an HTML-encoded String.
        /// </summary>
        /// <returns></returns>
        public HtmlString ChartScriptHtmlString()
        {
            var _scripts = new StringBuilder();

            _scripts.AppendLine("<script type='text/javascript'>");
            if (Options != null)
                _scripts.AppendLine("Highcharts.setOptions({0});".FormatWith(JsonSerializer.Serialize(Options)));

            _scripts.AppendLine("var {0};".FormatWith(Name));
            _scripts.AppendLine(!String.IsNullOrEmpty(FunctionName) ? String.Format("function {0}() {{", FunctionName) : "$(document).ready(function() {");
            _scripts.AppendHighstock(this);
            _scripts.AppendLine(!String.IsNullOrEmpty(FunctionName) ? "}" : "});");

            _scripts.AppendLine("</script>");

            return new HtmlString(_scripts.ToString());
        }

        #region IHtmlString Members

        public string ToHtmlString()
        {
            return ChartContainerHtmlString().ToString() + ChartScriptHtmlString();
        }

        #endregion IHtmlString Members

        public string GetOptions()
        {
            var _options = new StringBuilder();
            _options.Append(chart != null ? "chart: {{ renderTo:'{0}', {1} }}".FormatWith(ContainerName, JsonSerializer.Serialize(chart, false)) : "chart: {{ renderTo:'{0}' }}".FormatWith(ContainerName));

            if (credits != null)
            {
                _options.AppendLine(", ");
                _options.Append("credits: {0}".FormatWith(JsonSerializer.Serialize(credits)), 2);
            }

            if (labels != null)
            {
                _options.AppendLine(", ");
                _options.Append("labels: {0}".FormatWith(JsonSerializer.Serialize(labels)), 2);
            }

            if (legend != null)
            {
                _options.AppendLine(", ");
                _options.Append("legend: {0}".FormatWith(JsonSerializer.Serialize(legend)), 2);
            }

            if (loading != null)
            {
                _options.AppendLine(", ");
                _options.Append("loading: {0}".FormatWith(JsonSerializer.Serialize(loading)), 2);
            }

            if (plotOptions != null)
            {
                _options.AppendLine(", ");
                _options.Append("plotOptions: {0}".FormatWith(JsonSerializer.Serialize(plotOptions)), 2);
            }

            if (rangeSelector != null)
            {
                _options.AppendLine(", ");
                _options.Append("rangeSelector: {0}".FormatWith(JsonSerializer.Serialize(rangeSelector)), 2);
            }

            if (scrollbar != null)
            {
                _options.AppendLine(", ");
                _options.Append("scrollbar: {0}".FormatWith(JsonSerializer.Serialize(scrollbar)), 2);
            }

            if (subtitle != null)
            {
                _options.AppendLine(", ");
                _options.Append("subtitle: {0}".FormatWith(JsonSerializer.Serialize(subtitle)), 2);
            }

            if (title != null)
            {
                _options.AppendLine(", ");
                _options.Append("title: {0}".FormatWith(JsonSerializer.Serialize(title)), 2);
            }

            if (tooltip != null)
            {
                _options.AppendLine(", ");
                _options.Append("tooltip: {0}".FormatWith(JsonSerializer.Serialize(tooltip)), 2);
            }

            if (xAxis != null)
            {
                _options.AppendLine(", ");
                _options.Append("xAxis: {0}".FormatWith(JsonSerializer.Serialize(xAxis)), 2);
            }

            if (xAxisArray != null)
            {
                _options.AppendLine(", ");
                _options.Append("xAxis: {0}".FormatWith(JsonSerializer.Serialize(xAxisArray)), 2);
            }

            if (yAxis != null)
            {
                _options.AppendLine(", ");
                _options.Append("yAxis: {0}".FormatWith(JsonSerializer.Serialize(yAxis)), 2);
            }
            else if (yAxisArray != null)
            {
                _options.AppendLine(", ");
                _options.Append("yAxis: {0}".FormatWith(JsonSerializer.Serialize(yAxisArray)), 2);
            }

            if (exporting != null)
            {
                _options.AppendLine(", ");
                _options.Append("exporting: {0}".FormatWith(JsonSerializer.Serialize(exporting)), 2);
            }

            if (navigation != null)
            {
                _options.AppendLine(", ");
                _options.Append("navigation: {0}".FormatWith(JsonSerializer.Serialize(navigation)), 2);
            }

            if (navigator != null)
            {
                _options.AppendLine(", ");
                _options.Append("navigator: {0}".FormatWith(JsonSerializer.Serialize(navigator)), 2);
            }

            if (series != null)
            {
                _options.AppendLine(", ");
                _options.Append("series: [{0}]".FormatWith(JsonSerializer.Serialize(series)), 2);
            }
            else if (seriesArray != null)
            {
                _options.AppendLine(", ");
                _options.Append("series: {0}".FormatWith(JsonSerializer.Serialize(seriesArray)), 2);
            }

            _options.AppendLine();

            return _options.ToString();
        }
    }
}