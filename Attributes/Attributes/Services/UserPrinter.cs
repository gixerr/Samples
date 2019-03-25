using Attributes.Models;
using System;
using System.Diagnostics;
using System.Text;
using static System.Console;

namespace Attributes.Services
{
    public class UserPrinter
    {
        private readonly User _user;
        private ConsoleColor _color;

        public UserPrinter(User user)
        {
            _user = user;
        }

        [Obsolete("This will be removed in version 2")]
        //[Obsolete("This will be removed in version 2", error: true)]
        public void Print()
        {
            UseDefaultColor();
            PrintFirstName();
            PrintLastName();
            PrintAge();
        }

        private void UseDefaultColor()
        {
            var defaultColorAttribute =
                Attribute.GetCustomAttribute(typeof(User), typeof(DefaultColorAttribute))
                as DefaultColorAttribute;

            if (!(defaultColorAttribute is null))
            {
                ForegroundColor = defaultColorAttribute.Color;
            }
        }

        private void PrintFirstName()
        {
            var firstNameProperty = typeof(User).GetProperty(nameof(User.FirstName));
            var firstNameDisplayAttribute =
                Attribute.GetCustomAttribute(firstNameProperty, typeof(DisplayAttribute))
                as DisplayAttribute;

            var indentAttributes =
                Attribute.GetCustomAttributes(firstNameProperty, typeof(IndentAttribute))
                as IndentAttribute[];

            PreserveForegroundColor();

            var sb = new StringBuilder();

            if (!(indentAttributes is null))
            {
                foreach (var attribute in indentAttributes)
                {
                    sb.Append(' ', 4);
                }
            }

            if (!(firstNameDisplayAttribute is null))
            {
                ForegroundColor = firstNameDisplayAttribute.Color;
                sb.Append(firstNameDisplayAttribute.Label);
            }

            if (!(_user.FirstName is null))
            {
                sb.Append(_user.FirstName);
            }

            WriteLine(sb);
            RestoreForegroundColor();
        }

        private void PrintLastName() => WriteLine(_user.LastName);

        private void PrintAge()
        {
            OutputDebugInfo();
            OutputExtraInfo();
            WriteLine(_user.Age);
        }

        //Add "EXTRA" to Conditional compilation symbols in properties -> Build
        [Conditional("EXTRA")]
        private void OutputExtraInfo() => WriteLine("***EXTRA INFO***");

        [Conditional("DEBUG")]
        private void OutputDebugInfo() => WriteLine("***DEBUG MODE***");

        private void PreserveForegroundColor() => _color = ForegroundColor;

        private void RestoreForegroundColor() => ForegroundColor = _color;
    }
}
