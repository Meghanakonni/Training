using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_04
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string DOB { get; set; }
        public string DOJ { get; set; } 
        public string City { get; set; }
    }

    class Question_03
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>
            {

                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = "16/11/1984", DOJ = "8/6/2011", City = "Mumbai" },

                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = "20/08/1984", DOJ = "7/7/2012", City = "Mumbai" },

                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = "14/11/1987", DOJ = "12/4/2015", City = "Pune" },

                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = "3/6/1990", DOJ = "2/2/2016", City = "Pune" },

                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = "8/3/1991", DOJ = "2/2/2016", City = "Mumbai" },

                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = "7/11/1989", DOJ = "8/8/2014", City = "Chennai" },

                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = "2/12/1989", DOJ = "1/6/2015", City = "Mumbai" },

                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = "11/11/1993", DOJ = "6/11/2014", City = "Chennai" },

                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = "12/8/1992", DOJ = "3/12/2014", City = "Chennai" },

                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = "12/4/1991", DOJ = "2/1/2016", City = "Pune" }

            };

            // Displays details of all the employees

            Console.WriteLine("Employee Details:");
            foreach (var employee in empList)
            {
                Console.WriteLine($"{employee.EmployeeID} - {employee.FirstName} {employee.LastName}, {employee.Title}, {employee.City}, DOB: {employee.DOB}, DOJ: {employee.DOJ}");
            }

            // Displays details of all the employee whose location is not Mumbai

            var notInMumbai = empList.Where(employee => employee.City != "Mumbai").ToList();
            Console.WriteLine("\nEmployees not in Mumbai:");

            foreach (var employee in notInMumbai)
            {
                Console.WriteLine($"{employee.EmployeeID} - {employee.FirstName} {employee.LastName}, {employee.Title}, {employee.City}, DOB: {employee.DOB}, DOJ: {employee.DOJ}");
            }

            // Displays details of all the employee whose designation is AsstManager

            var asstManagers = empList.Where(employee => employee.Title == "AsstManager").ToList();
            Console.WriteLine("\nAsstManagers:");

            foreach (var employee in asstManagers)
            {
                Console.WriteLine($"{employee.EmployeeID} - {employee.FirstName} {employee.LastName}, {employee.Title}, {employee.City}, DOB: {employee.DOB}, DOJ: {employee.DOJ}");
            }

            // Displays details of all the employee whose Last Name starts with letter 'S'

            var startsWithS = empList.Where(employee => employee.LastName.StartsWith("S")).ToList();
            Console.WriteLine("\nEmployees with Last Name starting with 'S':");

            foreach (var employee in startsWithS)
            {
                Console.WriteLine($"{employee.EmployeeID} - {employee.FirstName} {employee.LastName}, {employee.Title}, {employee.City}, DOB: {employee.DOB}, DOJ: {employee.DOJ}");
            }
            Console.Read();
        }
    }
}
