using System;
using Assignment6;

namespace Concession
{
    class Program
    {
        const int TotalFare = 500; //constant value
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Please Enter Your Age: ");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                string concessionDetails = FareConcessionCalculator.CalculateConcession(age, name);
                Console.WriteLine(concessionDetails);
            }

            else
            {
                Console.WriteLine("Age Input is INVALID.");
            }
            Console.ReadLine();
        }
    }
}
