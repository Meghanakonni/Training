using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    class Customer
    {
        public int CustomerID;
        public string Name;
        public int Age;
        public long Phone;
        public string City;

        public Customer() //constructor with no arguments
        {
            CustomerID = 0;
            Name = "";
            Age = 0;
            Phone = 0;
            City = "";
        }

        public Customer(int ID,string name, int age, long phone, string city) //constructor with arguments
        {
            CustomerID = ID;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
        }

        public static void DisplayCustomerDetails(Customer cust)
        { 
            Console.WriteLine($"Customer ID: {cust.CustomerID}");
            Console.WriteLine($"Name: {cust.Name}");
            Console.WriteLine($"Age: {cust.Age}");
            Console.WriteLine($"Phone: {cust.Phone}");
            Console.WriteLine($"City: {cust.City}");
        }

        ~Customer() //Destructor
        {
        }
        class prgm
        {
            public static void Main()
            {
                Console.WriteLine("Enter the Customer ID:");
                int ID = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Customer Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Customer Age:");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Customer Phone Number:");
                long phone = long.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Customer City:");
                string city = Console.ReadLine(); 

                Customer cust = new Customer(ID, name, age, phone, city);
                Customer.DisplayCustomerDetails(cust);
            }
        }
    }
}