using DotNet.HighStock.Attributes;

namespace DotNet.HighStock.Helpers
{
    public class Events
    {
        [JsonFormatter("{0}")]
        public string Click
        {
            get;
            set;
        }

        [JsonFormatter("{0}")]
        public string Mouseover
        {
            get;
            set;
        }

        [JsonFormatter("{0}")]
        public string Mouseout
        {
            get;
            set;
        }

        [JsonFormatter("{0}")]
        public string Mousemove
        {
            get;
            set;
        }
    }
}