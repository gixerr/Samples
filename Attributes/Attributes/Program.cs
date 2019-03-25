using Attributes.Models;
using Attributes.Services;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User()
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 43
            };

            var userPrinter = new UserPrinter(user);
            userPrinter.Print();
        }
    }
}
