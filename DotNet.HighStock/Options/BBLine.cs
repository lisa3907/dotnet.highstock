using DotNet.HighStock.Helpers;
using System.Drawing;

namespace DotNet.HighStock.Options
{
    /// <summary>
    /// 
    /// </summary>
    public class BBLine
    {
        /// <summary>
        /// 
        /// </summary>
        public BBStyles Styles
        {
            get; set;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class BBStyles
    {
        /// <summary>
        /// <p>An array containing the default colors for the chart's series. When all colors are used, new colors are pulled from the start again. Defaults to:<pre>colors: ['#7cb5ec', '#434348', '#90ed7d', '#f7a35c', '#8085e9',    '#f15c80', '#e4d354', '#8085e8', '#8d4653', '#91e8e1']</pre>Default colors can also be set on a series or series.type basis, see <a href='#plotOptions.column.colors'>column.colors</a>, <a href='#plotOptions.pie.colors'>pie.colors</a>.</p><h3>Legacy</h3><p>In Highstock 3.x, the default colors were:<pre>colors: ['#2f7ed8', '#0d233a', '#8bbc21', '#910000', '#1aadce',    '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a']</pre></p><p>In Highstock 2.x, the default colors were:<pre>colors: ['#4572A7', '#AA4643', '#89A54E', '#80699B', '#3D96AE',    '#DB843D', '#92A8CD', '#A47D7C', '#B5CA92']</pre></p>
        /// Default: [ '#7cb5ec' , '#434348' , '#90ed7d' , '#f7a35c' , '#8085e9' , '#f15c80' , '#e4d354' , '#8085e8' , '#8d4653' , '#91e8e1']
        /// </summary>
        public Color? LineColor
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        public Number? LineWidth
        {
            get; set;
        }
    }
}