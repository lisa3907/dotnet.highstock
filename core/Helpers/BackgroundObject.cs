using System.Drawing;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Enums;

namespace DotNet.HighStock.Helpers
{
    public class BackgroundObject
    {
        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public BackColorOrGradient BackgroundColor
        {
            get;
            set;
        }

        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public PercentageOrPixel InnerRadius
        {
            get;
            set;
        }

        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public PercentageOrPixel OuterRadius
        {
            get;
            set;
        }

        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public PercentageOrPixel BorderWidth
        {
            get;
            set;
        }

        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public Color? BorderColor
        {
            get;
            set;
        }

        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public Shapes? Shape
        {
            get;
            set;
        }
    }
}