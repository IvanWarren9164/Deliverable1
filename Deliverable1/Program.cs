using System;
using System.Linq;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a password. The format is as follows: \n" +
                "1. At least one lowercase letter \n" +
                "2. At least one uppercase letter \n" +
                "3. A MINIMUM of 7 characters \n" +
                "4. A MAXIMUM of 12 characters \n" +
                "5. An exclamation point: ! \n");

            string password = Console.ReadLine();

            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Length >= 7 && password.Length <= 12 && password.Contains("!"))
                Console.WriteLine("Password valid and accepted \n");
            else
                Console.WriteLine("ERROR \n");

        }
    }
}
