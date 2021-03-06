using System;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DefaultColorAttribute : Attribute
    {
        public ConsoleColor Color { get; set; } = ConsoleColor.Yellow;
    }
}
