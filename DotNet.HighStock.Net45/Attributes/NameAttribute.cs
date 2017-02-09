using System;

namespace DotNet.HighStock.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class NameAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public NameAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get;
            private set;
        }
    }
}