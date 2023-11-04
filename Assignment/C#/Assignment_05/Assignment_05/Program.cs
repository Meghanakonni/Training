using System;

namespace Assignment_05
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            DisplayNames(firstName, lastName);
            Console.ReadKey();
        }

        static void DisplayNames(string firstName, string lastName)
        {
            Console.WriteLine($"First Name:{firstName.ToUpper()}");
            Console.WriteLine($"First Name:{lastName.ToUpper()}");
        }
    }
}
