using System;
using System.Diagnostics;

namespace Attributes.Models
{
    [DebuggerDisplay("First name = {FirstName}, Last name = {LastName}, Age = {Age}")]
    [DebuggerTypeProxy(typeof(UserDebugDisplay))]
    [DefaultColor(Color = ConsoleColor.Blue)]
    public class User
    {
        [Display("First name: ", ConsoleColor.Green)]
        [Indent]
        [Indent]
        [Indent]
        [Indent]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int Age { get; set; }
    }
}
