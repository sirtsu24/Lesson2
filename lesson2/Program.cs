using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string firstName;
            string lastName;
            string favoriteColor;
            Console.WriteLine("Enter your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your lastname:");
            lastName = Console.ReadLine();
            //Console.WriteLine("Nice to meet you, " + firstName + " " + lastName + "!");
            //I'm just a comment
           // Console.WriteLine("Nice to meet you {0} {1}", firstName, lastName);
            
            Console.WriteLine("Whats your favorite color?");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is {0}", color);
            Console.WriteLine("Hello, {0} {1}. Your favorite color is {2}", firstName, lastName, favoriteColor);
            Console.ReadLine();
        }
    }
}
