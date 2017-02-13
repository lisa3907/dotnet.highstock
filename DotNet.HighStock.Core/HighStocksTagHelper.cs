using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Options;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DotNet.HighStock
{
    public class HighStocksTagHelper : TagHelper
    {
        /// <summary>
        /// 차트 제목
        /// </summary>
        [HtmlAttributeName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 차트 종류
        /// </summary>
        [HtmlAttributeName("type")]
        public ChartTypes Type { get; set; }

        /// <summary>
        /// 차트 레벨 2 헤드 라인
        /// </summary>
        [HtmlAttributeName("subtitle")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 데이터 개체
        /// </summary>
        [HtmlAttributeName("series")]
        public Series Series { get; set; }

        /// <summary>
        /// 일부 추가 옵션
        /// </summary>
        [HtmlAttributeName("plotoptions")]
        public string PlotOptions { get; set; }

        /// <summary>
        /// X 축 선택
        /// </summary>
        [HtmlAttributeName("xAxis")]
        public List<XAxis> XAxis { get; set; }

        /// <summary>
        /// Y 축 선택
        /// </summary>
        [HtmlAttributeName("yAxis")]
        public List<YAxis> YAxis { get; set; }

        /// <summary>
        /// 툴팁 형식
        /// </summary>
        [HtmlAttributeName("Tooltip")]
        public string Tooltip { get; set; }

        /// <summary>
        /// 컨테이너 ID
        /// </summary>
        [HtmlAttributeName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 범례
        /// </summary>
        [HtmlAttributeName("legend")]
        public bool Legend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [HtmlAttributeName("serieslist")]
        public List<Series> SeriesList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [HtmlAttributeName("width")]
        public int Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [HtmlAttributeName("height")]
        public int Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [HtmlAttributeName("stock")]
        public HighStock Stock { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Stock != null)
            {
                output.Attributes.SetAttribute("title", "DotNet.HighStock.Core");
                output.Attributes.SetAttribute("id", Id);

                var _style = new StringBuilder("margin:0px auto;min-width:400px;");
                if (Width > 0)
                    _style.Append($"width:{Width}px;");
                if (Height > 0)
                    _style.Append($"heigth:{Height}px;");
                output.Attributes.SetAttribute("style", _style.ToString());
                output.TagName = "div";

                output.PostElement.AppendHtml(Stock.ToHtmlString());
            }
        }
    }
}