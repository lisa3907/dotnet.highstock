using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DotNet.HighStock
{
    public class HighStocksTagHelper : TagHelper
    {
        /// <summary>
        /// 차트 제목
        /// </summary>
        [HtmlAttributeName("title")]
        public string Title
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [HtmlAttributeName("width")]
        public int Width
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [HtmlAttributeName("height")]
        public int Height
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [HtmlAttributeName("stock")]
        public HighStock Stock
        {
            get; set;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Stock != null)
            {
                output.Attributes.SetAttribute("title", Title);
                output.Attributes.SetAttribute("id", Stock.ContainerName);

                var _style = new StringBuilder("margin:0px auto;min-width:400px;");
                if (Width > 0)
                    _style.Append($"width:{Width}px;");
                if (Height > 0)
                    _style.Append($"heigth:{Height}px;");
                output.Attributes.SetAttribute("style", _style.ToString());
                output.TagName = "div";

                output.PostElement.AppendHtml(Stock.ChartScriptHtmlString());
            }
        }
    }
}