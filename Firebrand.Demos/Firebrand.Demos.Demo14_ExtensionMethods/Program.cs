using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos.Demo14_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Is {0} a valid email? {1}", email, email.IsValidEmail());
            Console.ReadKey();
        }
    }

    static class MyFunctions 
    {
        public static bool IsValidEmail(this string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
    }
}
