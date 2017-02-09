using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DotNet.HighStock
{
    public class Container : IHtmlString
    {
        readonly List<Highstock> _Highstock;

        public Container(IEnumerable<Highstock> highstock)
        {
            _Highstock = new List<Highstock>();
            _Highstock.AddRange(highstock);
        }

        #region IHtmlString Members

        public string ToHtmlString()
        {
            StringBuilder scripts = new StringBuilder();
            _Highstock.ForEach(x => scripts.AppendLine("<div id='{0}'></div>".FormatWith(x.ContainerName)));

            List<Highstock> startupCharts = _Highstock.Where(x => String.IsNullOrEmpty(x.FunctionName)).ToList();
            scripts.AppendLine("<script type='text/javascript'>");
            startupCharts.ForEach(x => scripts.AppendLine("var {0};".FormatWith(x.Name)));
            scripts.AppendLine("$(document).ready(function() {");
            startupCharts.ForEach(scripts.AppendHighstock);
            scripts.AppendLine("});");

            List<Highstock> functionCharts = _Highstock.Where(x => !String.IsNullOrEmpty(x.FunctionName)).ToList();
            foreach (Highstock chart in functionCharts)
            {
                scripts.AppendLine("var {0};".FormatWith(chart.Name));
                scripts.AppendLine(String.Format("function {0}() {{", chart.FunctionName));
                scripts.AppendHighstock(chart);
                scripts.AppendLine("}");
            }
            scripts.AppendLine("</script>");

            return scripts.ToString();
        }

        #endregion
    }
}