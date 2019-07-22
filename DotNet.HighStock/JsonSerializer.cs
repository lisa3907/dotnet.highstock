using DotNet.HighStock.Attributes;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DotNet.HighStock
{
    public class JsonSerializer
    {
        private const string JSON_STRING_ARRAY = "['{0}']";
        private const string JSON_NUMBER_ARRAY = "[{0}]";
        private const string JSON_NUMBER_MULTI_ARRAY = "[{0}, {1}]";
        private const string JSON_OBJECT_FORMAT = "{{ {0} }}";
        private const string JSON_PROPERTY_WITH_VALUE_FORMAT = "{0}: {1}";
        private const string JSON_STRING_FORMAT = "'{0}'";
        private const string JSON_DEFAULT_FORMAT = "{0}";
        private const string JSON_DATE_FORMAT = "Date.parse('{0}')";
        private const string NULL_STRING = "null";

        public static string Serialize<T>(T obj) where T : class
        {
            return Serialize(obj, true);
        }

        public static string Serialize<T>(T obj, bool appendCurlyBrackets) where T : class
        {
            if (obj is Array)
                return GetJsonArray(obj as Array, true);

            return GetJsonObject(obj, appendCurlyBrackets);
        }

        private static string GetJsonArray(Array obj, bool useCurlyBracketsForObject)
        {
            if (obj is string[])
            {
                StringBuilder values = new StringBuilder();
                foreach (object value in obj)
                {
                    values.Append(GetJsonString(String.Empty, JSON_STRING_FORMAT, value.ToString()) + ", ");
                }
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, (values.Length > 2) ? values.ToString(0, values.Length - 2) : values.ToString());
            }
            if (obj is int[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", (obj as int[])));
            if (obj is int?[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", from int? item in obj
                                                                                                                            select GetJsonObject(item, false)));
            if (obj is short[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", (obj as short[])));
            if (obj is short?[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", from short? item in obj
                                                                                                                            select GetJsonObject(item, false)));
            if (obj is long[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", (obj as long[])));
            if (obj is long?[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", from long? item in obj
                                                                                                                            select GetJsonObject(item, false)));
            if (obj is double[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", (obj as double[]).Select(p => p.ToString(CultureInfo.InvariantCulture))));
            if (obj is double?[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", from double? item in obj
                                                                                                                            select GetJsonObject(item, false)));
            if (obj is decimal[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", (obj as decimal[]).Select(p => p.ToString(CultureInfo.InvariantCulture))));
            if (obj is decimal?[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", from decimal? item in obj
                                                                                                                            select GetJsonObject(item, false)));
            if (obj is Number[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", (obj as Number[])));
            if (obj is Number?[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", from Number? item in obj
                                                                                                                            select GetJsonObject(item, false)));
            if (obj is PercentageOrPixel[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", from object item in obj
                                                                                                                            select GetJsonObject((item as PercentageOrPixel).Value, false)));
            if (obj is bool[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", from object item in obj
                                                                                                                            select GetJsonObject(item, true)));
            if (obj is Color[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", from Color item in obj
                                                                                                                            select GetColorString(JSON_STRING_FORMAT, item)));
            if (obj is object[])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, String.Join(", ", from object item in obj
                                                                                                                            select GetJsonObject(item, true)));
            if (obj is object[,])
                return String.Format(useCurlyBracketsForObject ? JSON_NUMBER_ARRAY : JSON_DEFAULT_FORMAT, GetMultiDimentionArray(obj as object[,]));

            throw new NotImplementedException("Not implemented serialization array of type: " + obj.GetType());
        }

        private static string GetJsonObject(object obj, bool appendCurlyBrackets)
        {
            if (obj == null)
                return NULL_STRING;

            if (obj.GetType().GetTypeInfo().IsPrimitive || obj is decimal || obj is String || obj is Color || obj is DateTime)
            {
                return GetValue(obj, obj.GetType(), GetJsonFormatter(null));
            }

            if (obj is Array)
                return GetJsonArray(obj as Array, appendCurlyBrackets);

            List<string> json = new List<string>();

            foreach (PropertyInfo property in obj.GetType().GetMembers().Where(x => x.MemberType == MemberTypes.Property))
            {
                object propertyValue = property.GetValue(obj, null);
                JsonFormatter formatter = GetJsonFormatter(property);

                if (propertyValue != null)
                {
                    Type propertyType = property.PropertyType;
                    string propertyName = GetPropertyName(property);

                    string value;
                    if (propertyType == typeof(Array) || propertyType.GetTypeInfo().BaseType == typeof(Array) || propertyValue is Array)
                        value = GetJsonArray(propertyValue as Array, formatter.UseCurlyBracketsForObject);
                    else if (propertyType.GetTypeInfo().IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        value = GetValue(propertyValue, propertyType.GetGenericArguments()[0], formatter);
                    else
                        value = GetValue(propertyValue, propertyType, formatter);

                    json.Add(formatter.AddPropertyName ? String.Format(JSON_PROPERTY_WITH_VALUE_FORMAT, GetFirstLetterLower(propertyName), value) : value);
                }
            }
            return appendCurlyBrackets ? String.Format(JSON_OBJECT_FORMAT, String.Join(", ", json)) : String.Join(", ", json);
        }

        private static string GetValue(object value, Type type, JsonFormatter formatter)
        {
            if (value is string)
            {
                string jsonFormat = JSON_STRING_FORMAT;
                if (IsNumeric(value))
                    jsonFormat = JSON_DEFAULT_FORMAT;

                string valueString = value.ToString().Replace("\r\n", " ").Replace("  ", "");
                if (valueString.StartsWith("'") && valueString.EndsWith("'"))
                    valueString = valueString.Trim('\'');
                return GetJsonString(formatter.JsonValueFormat, jsonFormat, valueString);
            }
            if (value is int || value is long || value is short || value is byte || type == typeof(Number))
                return GetJsonString(formatter.JsonValueFormat, JSON_DEFAULT_FORMAT, value.ToString());
            if (value is double)
                return GetJsonString(formatter.JsonValueFormat, JSON_DEFAULT_FORMAT, ((double)value).ToString(CultureInfo.InvariantCulture));
            if (value is decimal)
                return GetJsonString(formatter.JsonValueFormat, JSON_DEFAULT_FORMAT, ((decimal)value).ToString(CultureInfo.InvariantCulture));
            if (value is bool)
                return GetJsonString(formatter.JsonValueFormat, JSON_DEFAULT_FORMAT, value.ToString().ToLowerInvariant());
            if (value is Color)
                return GetColorString(formatter.JsonValueFormat, value);
            if (value is DateTime)
                return GetJsonString(formatter.JsonValueFormat, JSON_DATE_FORMAT, ((DateTime)value).ToString(CultureInfo.InvariantCulture));
            if (type.GetTypeInfo().IsEnum)
                return GetEnumString(formatter.JsonValueFormat, type, value);
            if ((type.GetTypeInfo().BaseType != null && type.GetTypeInfo().BaseType == typeof(object)) || type.GetTypeInfo().IsClass)
                return GetJsonString(formatter.JsonValueFormat, JSON_DEFAULT_FORMAT, GetJsonObject(value, formatter.UseCurlyBracketsForObject));

            throw new NotImplementedException("Not implemented serialization for type: " + type.Name);
        }

        private static bool IsNumeric(object expression)
        {
            if (expression == null)
                return false;

            double number;
            return Double.TryParse(Convert.ToString(expression, CultureInfo.InvariantCulture), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out number);
        }

        private static string GetEnumString(string format, Type type, object value)
        {
            if (type == typeof(WeekDays))
                return GetJsonString(format, JSON_DEFAULT_FORMAT, ((int)value).ToString());

            return GetJsonString(format, JSON_STRING_FORMAT, GetFirstLetterLower(value.ToString().Replace("_", "-")));
        }

        private static string GetColorString(string format, object obj)
        {
            Color color = (Color)obj;
            //if (color.IsNamedColor)
            //    return color.IsKnownColor ? GetJsonString(format, JSON_STRING_FORMAT, color.Name.ToLower()) : GetJsonString(format, JSON_DEFAULT_FORMAT, color.Name);
            //if (color.A == 255)
            //    return GetJsonString(format, JSON_STRING_FORMAT, ColorTranslator.ToHtml(color));
            return GetJsonString(format, JSON_STRING_FORMAT, GetRgbColor(color));
        }

        private static string GetRgbColor(Color color)
        {
            double htmlAlpha = (double)color.A / 255;
            return String.Format("rgba({0}, {1}, {2}, {3})", color.R, color.G, color.B, htmlAlpha.ToString("#.#", CultureInfo.InvariantCulture));
        }

        private static string GetJsonString(string format, string defaultFormat, string value)
        {
            return String.Format(!String.IsNullOrEmpty(format) ? format : defaultFormat, value);
        }

        private static string GetPropertyName(PropertyInfo property)
        {
            string propertyName = String.Empty;
            foreach (NameAttribute attribute in property.GetCustomAttributes(typeof(NameAttribute), true))
                propertyName = attribute.Name;

            if (String.IsNullOrEmpty(propertyName))
                propertyName = property.Name;

            return propertyName;
        }

        private static string GetFirstLetterLower(string name)
        {
            return Char.ToLowerInvariant(name[0]) + name.Substring(1);
        }

        private static JsonFormatter GetJsonFormatter(PropertyInfo property)
        {
            JsonFormatter formatter = new JsonFormatter
            {
                JsonValueFormat = String.Empty,
                AddPropertyName = true,
                UseCurlyBracketsForObject = true
            };
            if (property != null)
                foreach (JsonFormatterAttribute attribute in property.GetCustomAttributes(typeof(JsonFormatterAttribute), true))
                    formatter = attribute.JsonFormatter;

            return formatter;
        }

        private static string GetMultiDimentionArray(object[,] array)
        {
            List<string> json = new List<string>();
            for (int i = 0; i <= array.GetUpperBound(0); i++)
                json.Add(String.Format(JSON_NUMBER_MULTI_ARRAY, GetJsonObject(array[i, 0], true), GetJsonObject(array[i, 1], true)));
            return String.Join(", ", json);
        }
    }
}