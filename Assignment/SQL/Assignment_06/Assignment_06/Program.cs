using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime DOB { get; set; }
    public DateTime DOJ { get; set; }
    public string City { get; set; }
}
class Program
{
    static void Main()
    {

        List<Employee> empList = new List<Employee>
        {
               new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 8, 6), City = "Mumbai" },

               new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },

               new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 12, 4), City = "Pune" },

               new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },

               new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 8, 3), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },

               new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 7, 11), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },

               new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 2, 12), DOJ = new DateTime(2015, 1, 6), City = "Mumbai" },

               new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 6, 11), City = "Chennai" },

               new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 12, 8), DOJ = new DateTime(2014, 3, 12), City = "Chennai" },

               new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 2, 1), City = "Pune" }
        };

        var before_2015 = empList.Where(e => e.DOJ < new DateTime(2015, 1, 1));
        Console.WriteLine("1: Display employees joined before 1/1/2015");

        foreach (var employee in before_2015)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
        }

        var after_1990 = empList.Where(e => e.DOB > new DateTime(1990, 1, 1));
        Console.WriteLine("\n****************************************************************");
        Console.WriteLine("2: Employees with DOB after 1/1/1990:");
        foreach (var employee in after_1990)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
        }

        var consultantsAndAssociates = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");
        Console.WriteLine("\n****************************************************************");
        Console.WriteLine("3. Employees with designation 'Consultant' or 'Associate':");

        foreach (var employee in consultantsAndAssociates)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
        }

        int total_Employees = empList.Count;
        Console.WriteLine("\n****************************************************************");
        Console.WriteLine($"4. Total number of employees: {total_Employees}");

        int chennaiEmployees = empList.Count(e => e.City == "Chennai");
        Console.WriteLine("\n****************************************************************");
        Console.WriteLine($"5. Total number of employees in Chennai: {chennaiEmployees}");

        int highestEmployeeID = empList.Max(e => e.EmployeeID);
        Console.WriteLine("\n****************************************************************");
        Console.WriteLine($"6. Highest Employee ID: {highestEmployeeID}");

        int employeesJoinedAfter2015 = empList.Count(e => e.DOJ > new DateTime(2015, 1, 1));
        Console.WriteLine("\n****************************************************************");
        Console.WriteLine($"7. Employees joined after 1/1/2015: {employeesJoinedAfter2015}");

        int nonAssociateEmployees = empList.Count(e => e.Title != "Associate");
        Console.WriteLine("\n****************************************************************");
        Console.WriteLine($"8. Employees with a designation other than 'Associate': {nonAssociateEmployees}");

        var cityGrouping = empList.GroupBy(e => e.City);
        Console.WriteLine("\n****************************************************************");
        Console.WriteLine("9. Total number of employees based on City:");

        foreach (var group in cityGrouping)
        {
            Console.WriteLine($"{group.Key}: {group.Count()}");
        }

        
        var cityTitleGrouping = empList.GroupBy(e => new { e.City, e.Title });
        Console.WriteLine("\n****************************************************************");
        Console.WriteLine("10. Total number of employees based on City and Title:");

        foreach (var group in cityTitleGrouping)
        {
            Console.WriteLine($"{group.Key.City} ({group.Key.Title}): {group.Count()}");
        }

        var youngestEmployee = empList.OrderBy(e => e.DOB).LastOrDefault();
        Console.WriteLine("\n****************************************************************");
        Console.WriteLine("11. Youngest employee:");
        Console.WriteLine($"{youngestEmployee.FirstName} {youngestEmployee.LastName}");
        Console.Read();
    }
}