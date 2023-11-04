using System;

namespace Test_02
{

    abstract class Student
    {
        public string Name { get; set; }
        public int StudentID { get; set; }
        public double Grade { get; set; }
        public abstract bool IsPassed(double Grade);
    }  
    class UnderGrad: Student 
    {
        public override bool IsPassed(double Grade)
        {
            return Grade > 70.0;
        }
    }

    class Grad: Student
    {
        public override bool IsPassed(double Grade)
        {
            return Grade > 80.0;
        }
    }
    class Program
    {
        static void Main()
        {
            UnderGrad underGrad = new UnderGrad
            
            {
                Name = "Meghana",
                StudentID = 45576,
                Grade = 80.0
            };                                          

            bool passedUnderGrad = underGrad.IsPassed(underGrad.Grade);
            Console.WriteLine($"UnderGraduate Student {underGrad.Name} Passed: {passedUnderGrad} ");

            Grad Graduate = new Grad { 
            Name = "Kameshwari",
            StudentID = 7867,
            Grade = 90.0};

            bool passedGrad = Graduate.IsPassed(Graduate.Grade);
            Console.WriteLine($"Graduate Student {Graduate.Name} Passed: {passedGrad} ");


        }
    }
}
