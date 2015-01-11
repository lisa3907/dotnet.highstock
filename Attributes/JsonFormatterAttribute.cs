using System;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Attributes
{
    /// <summary>
    /// Define the JSON format for this property. First the name of the property and then the value.
    /// <example>
    /// Example: {0}: '{1}'
    /// </example>
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class JsonFormatterAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="jsonValueFormat"></param>
        /// <param name="addPropertyName"></param>
        /// <param name="useCurlyBracketsForObject"></param>
        public JsonFormatterAttribute(string jsonValueFormat = "", bool addPropertyName = true, bool useCurlyBracketsForObject = true)
        {
            JsonFormatter = new JsonFormatter
            {
                JsonValueFormat = jsonValueFormat,
                AddPropertyName = addPropertyName,
                UseCurlyBracketsForObject = useCurlyBracketsForObject
            };
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonFormatter JsonFormatter
        {
            get;
            private set;
        }
    }
}