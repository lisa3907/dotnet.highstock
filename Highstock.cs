using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using DotNet.Highstock.Helpers;
using DotNet.Highstock.Options;

namespace DotNet.Highstock
{
    public class Highstock : IHtmlString
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

        Chart _Chart;
        Credits _Credits;
        Exporting _Exporting;
        Labels _Labels;
        Legend _Legend;
        Loading _Loading;
        Navigation _Navigation;
        Navigator _Navigator;
        PlotOptions _PlotOptions;
        RangeSelector _RangeSelector;
        Scrollbar _Scrollbar;
        Series _Series;
        Series[] _SeriesArray;
        Subtitle _Subtitle;
        Title _Title;
        Tooltip _Tooltip;
        XAxis _XAxis;
        XAxis[] _XAxisArray;
        YAxis _YAxis;
        YAxis[] _YAxisArray;

        /// <summary>
        /// The chart object is the JavaScript object representing a single chart in the web page.
        /// </summary>
        /// <param name="name">The object name of the chart and related container</param>
        /// <see cref="http://api.highcharts.com/highstock"/>
        public Highstock(string name)
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
        public Highstock SetOptions(GlobalOptions options)
        {
            Options = options;
            return this;
        }

        /// <summary>
        /// Options regarding the chart area and plot area as well as general chart options.
        /// </summary>
        /// <param name="chart"></param>
        /// <returns></returns>
        public Highstock InitChart(Chart chart)
        {
            _Chart = chart;
            return this;
        }

        /// <summary>
        /// Highchart by default puts a credits label in the lower right corner of the chart. 
        /// This can be changed using these options.
        /// </summary>
        public Highstock SetCredits(Credits credits)
        {
            _Credits = credits;
            return this;
        }

        /// <summary>
        /// Options for the exporting module.
        /// </summary>
        /// <param name="exporting"></param>
        /// <returns></returns>
        public Highstock SetExporting(Exporting exporting)
        {
            _Exporting = exporting;
            return this;
        }

        /// <summary>
        /// HTML labels that can be positioined anywhere in the chart area.
        /// </summary>
        /// <param name="labels"></param>
        /// <returns></returns>
        public Highstock SetLabels(Labels labels)
        {
            _Labels = labels;
            return this;
        }

        /// <summary>
        /// The legend is a box containing a symbol and name for each series item or point item in the chart.
        /// </summary>
        /// <param name="legend"></param>
        /// <returns></returns>
        public Highstock SetLegend(Legend legend)
        {
            _Legend = legend;
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
        public Highstock SetLoading(Loading loading)
        {
            _Loading = loading;
            return this;
        }

        /// <summary>
        /// A collection of options for buttons and menus appearing in the exporting module.
        /// </summary>
        /// <param name="navigation"></param>
        /// <returns></returns>
        public Highstock SetNavigation(Navigation navigation)
        {
            _Navigation = navigation;
            return this;
        }

        /// <summary>
        /// The navigator is a small series below the main series, displaying a view of the entire data set. 
        /// It provides tools to zoom in and out on parts of the data as well as panning across the dataset.
        /// </summary>
        /// <param name="navigator"></param>
        /// <returns></returns>
        public Highstock SetNavigator(Navigator navigator)
        {
            _Navigator = navigator;
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
        public Highstock SetPlotOptions(PlotOptions plotOptions)
        {
            _PlotOptions = plotOptions;
            return this;
        }

        /// <summary>
        /// The range selector is a tool for selecting ranges to display within the chart. 
        /// It provides buttons to select preconfigured ranges in the chart, like 1 day, 1 week, 1 month etc. 
        /// It also provides input boxes where min and max dates can be manually input.
        /// </summary>
        /// <param name="rangeSelector"></param>
        /// <returns></returns>
        public Highstock SetRangeSelector(RangeSelector rangeSelector)
        {
            _RangeSelector = rangeSelector;
            return this;
        }

        /// <summary>
        /// The scrollbar is a means of panning over the X axis of a chart.
        /// </summary>
        /// <param name="scrollbar"></param>
        /// <returns></returns>
        public Highstock SetScrollbar(Scrollbar scrollbar)
        {
            _Scrollbar = scrollbar;
            return this;
        }

        /// <summary>
        /// The actual series to append to the chart. In addition to the members listed below, any member of the plotOptions 
        /// for that specific type of plot can be added to a series individually. For example, even though a general lineWidth 
        /// is specified in plotOptions.series, an individual lineWidth can be specified for each series.
        /// </summary>
        /// <param name="series"></param>
        /// <returns></returns>
        public Highstock SetSeries(Series series)
        {
            _Series = series;
            return this;
        }

        /// <summary>
        /// The actual series to append to the chart. In addition to the members listed below, any member of the plotOptions 
        /// for that specific type of plot can be added to a series individually. For example, even though a general lineWidth 
        /// is specified in plotOptions.series, an individual lineWidth can be specified for each series.
        /// </summary>
        /// <param name="seriesArray">Array of series options.</param>
        /// <returns></returns>
        public Highstock SetSeries(Series[] seriesArray)
        {
            _SeriesArray = seriesArray;
            return this;
        }

        /// <summary>
        /// The chart's subtitle
        /// </summary>
        /// <param name="subtitle">The subtitle options.</param>
        /// <returns></returns>
        public Highstock SetSubtitle(Subtitle subtitle)
        {
            _Subtitle = subtitle;
            return this;
        }

        /// <summary>
        /// The chart's main title.
        /// </summary>
        /// <param name="title">The title options.</param>
        /// <returns></returns>
        public Highstock SetTitle(Title title)
        {
            _Title = title;
            return this;
        }

        /// <summary>
        /// Options for the tooltip that appears when the user hovers over a series or point.
        /// </summary>
        /// <param name="tooltip">The tooltip options.</param>
        /// <returns></returns>
        public Highstock SetTooltip(Tooltip tooltip)
        {
            _Tooltip = tooltip;
            return this;
        }

        /// <summary>
        /// The X axis or category axis. Normally this is the horizontal axis, though if the chart is inverted this is the vertical axis.
        /// In case of multiple axes, the xAxis node is an array of configuration objects.
        /// </summary>
        /// <param name="xAxis">The X axis options.</param>
        /// <returns></returns>
        public Highstock SetXAxis(XAxis xAxis)
        {
            _XAxis = xAxis;
            return this;
        }

        /// <summary>
        /// The X axis or category axis. Normally this is the horizontal axis, though if the chart is inverted this is the vertical axis.
        /// In case of multiple axes, the xAxis node is an array of configuration objects.
        /// </summary>
        /// <param name="xAxisArray">Array of X axis options.</param>
        /// <returns></returns>
        public Highstock SetXAxis(XAxis[] xAxisArray)
        {
            _XAxisArray = xAxisArray;
            return this;
        }

        /// <summary>
        /// The Y axis or value axis. Normally this is the vertical axis, though if the chart is inverted this is the horiontal axis.
        /// In case of multiple axes, the yAxis node is an array of configuration objects.
        /// </summary>
        /// <param name="yAxis">The Y axis options.</param>
        /// <returns></returns>
        public Highstock SetYAxis(YAxis yAxis)
        {
            _YAxis = yAxis;
            return this;
        }

        /// <summary>
        /// Sets the y axis.
        /// </summary>
        /// <param name="yAxisArray">Array Y axis options.</param>
        /// <returns></returns>
        public Highstock SetYAxis(YAxis[] yAxisArray)
        {
            _YAxisArray = yAxisArray;
            return this;
        }

        /// <summary>
        /// Add the javascript variable to the same jQuery document ready where chart is initialized.
        /// Variables are added before the chart.
        /// </summary>
        /// <param name="name">The name of the variable.</param>
        /// <param name="value">The value of the variable.</param>
        /// <returns></returns>
        public Highstock AddJavascripVariable(string name, string value)
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
        public Highstock AddJavascripFunction(string name, string body, params string[] variables)
        {
            JsFunctions.Add("function {0}({1}){{".FormatWith(name, String.Join(", ", variables)), body);
            return this;
        }

        public Highstock InFunction(string name)
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
            StringBuilder scripts = new StringBuilder();

            scripts.AppendLine("<script type='text/javascript'>");
            if (Options != null)
                scripts.AppendLine("Highstock.setOptions({0});".FormatWith(JsonSerializer.Serialize(Options)));

            scripts.AppendLine("var {0};".FormatWith(Name));
            scripts.AppendLine(!String.IsNullOrEmpty(FunctionName) ? String.Format("function {0}() {{", FunctionName) : "$(document).ready(function() {");
            scripts.AppendHighstock(this);
            scripts.AppendLine(!String.IsNullOrEmpty(FunctionName) ? "}" : "});");

            scripts.AppendLine("</script>");

            return new HtmlString(scripts.ToString());
        }

        #region IHtmlString Members

        public string ToHtmlString()
        {
            return ChartContainerHtmlString().ToString() + ChartScriptHtmlString();
        }

        #endregion

        public string GetOptions()
        {
            StringBuilder options = new StringBuilder();
            options.Append(_Chart != null ? "chart: {{ renderTo:'{0}', {1} }}".FormatWith(ContainerName, JsonSerializer.Serialize(_Chart, false)) : "chart: {{ renderTo:'{0}' }}".FormatWith(ContainerName));

            if (_Credits != null)
            {
                options.AppendLine(", ");
                options.Append("credits: {0}".FormatWith(JsonSerializer.Serialize(_Credits)), 2);
            }

            if (_Labels != null)
            {
                options.AppendLine(", ");
                options.Append("labels: {0}".FormatWith(JsonSerializer.Serialize(_Labels)), 2);
            }

            if (_Legend != null)
            {
                options.AppendLine(", ");
                options.Append("legend: {0}".FormatWith(JsonSerializer.Serialize(_Legend)), 2);
            }

            if (_Loading != null)
            {
                options.AppendLine(", ");
                options.Append("loading: {0}".FormatWith(JsonSerializer.Serialize(_Loading)), 2);
            }

            if (_PlotOptions != null)
            {
                options.AppendLine(", ");
                options.Append("plotOptions: {0}".FormatWith(JsonSerializer.Serialize(_PlotOptions)), 2);
            }

            if (_RangeSelector != null)
            {
                options.AppendLine(", ");
                options.Append("rangeSelector: {0}".FormatWith(JsonSerializer.Serialize(_RangeSelector)), 2);
            }

            if (_Scrollbar != null)
            {
                options.AppendLine(", ");
                options.Append("scrollbar: {0}".FormatWith(JsonSerializer.Serialize(_Scrollbar)), 2);
            }

            if (_Subtitle != null)
            {
                options.AppendLine(", ");
                options.Append("subtitle: {0}".FormatWith(JsonSerializer.Serialize(_Subtitle)), 2);
            }

            if (_Title != null)
            {
                options.AppendLine(", ");
                options.Append("title: {0}".FormatWith(JsonSerializer.Serialize(_Title)), 2);
            }

            if (_Tooltip != null)
            {
                options.AppendLine(", ");
                options.Append("tooltip: {0}".FormatWith(JsonSerializer.Serialize(_Tooltip)), 2);
            }

            if (_XAxis != null)
            {
                options.AppendLine(", ");
                options.Append("xAxis: {0}".FormatWith(JsonSerializer.Serialize(_XAxis)), 2);
            }

            if (_XAxisArray != null)
            {
                options.AppendLine(", ");
                options.Append("xAxis: {0}".FormatWith(JsonSerializer.Serialize(_XAxisArray)), 2);
            }

            if (_YAxis != null)
            {
                options.AppendLine(", ");
                options.Append("yAxis: {0}".FormatWith(JsonSerializer.Serialize(_YAxis)), 2);
            }
            else if (_YAxisArray != null)
            {
                options.AppendLine(", ");
                options.Append("yAxis: {0}".FormatWith(JsonSerializer.Serialize(_YAxisArray)), 2);
            }

            if (_Exporting != null)
            {
                options.AppendLine(", ");
                options.Append("exporting: {0}".FormatWith(JsonSerializer.Serialize(_Exporting)), 2);
            }

            if (_Navigation != null)
            {
                options.AppendLine(", ");
                options.Append("navigation: {0}".FormatWith(JsonSerializer.Serialize(_Navigation)), 2);
            }

            if (_Navigator != null)
            {
                options.AppendLine(", ");
                options.Append("navigator: {0}".FormatWith(JsonSerializer.Serialize(_Navigator)), 2);
            }

            if (_Series != null)
            {
                options.AppendLine(", ");
                options.Append("series: [{0}]".FormatWith(JsonSerializer.Serialize(_Series)), 2);
            }
            else if (_SeriesArray != null)
            {
                options.AppendLine(", ");
                options.Append("series: {0}".FormatWith(JsonSerializer.Serialize(_SeriesArray)), 2);
            }

            options.AppendLine();

            return options.ToString();
        }
    }
}