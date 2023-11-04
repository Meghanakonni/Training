using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_03
{
    class Box
    {
        private double length; //instead of {get;set;} I used Get and Set Functions Mam
        private double breadth;

        // Get and Set for Length
        public double GetLength() 
        {
            return length;
        }
        public void SetLength(double value)
        {
            length = value;
        }

        //Get and Set for Breadth
        public double GetBreadth()
        {
            return breadth;
        }
        public void SetBreadth(double value)
        {
            breadth = value;
        }
        public Box(double length, double breadth)
        {
            SetLength(length);
            SetBreadth(breadth);
        }
        public static Box Add(Box box1, Box box2)
        {
            double newLength = box1.GetLength() + box2.GetLength();
            double newBreadth = box1.GetBreadth() + box2.GetBreadth();
            return new Box(newLength, newBreadth);
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Length: {GetLength()}");
            Console.WriteLine($"Breadth: {GetBreadth()}");
        }

    }
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Dimensions for Box1: "); //details of box1

            Console.WriteLine("Length:");
            double length1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Breadth:");
            double breadth1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Dimensions for Box2: "); //details of box2

            Console.WriteLine("Length:");
            double length2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Breadth:");
            double breadth2 = Convert.ToDouble(Console.ReadLine());

            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);
            Box box3 = Box.Add(box1, box2);

            Console.WriteLine("Details of Box-1:");
            box1.DisplayDetails();

            Console.WriteLine("Details of Box-2:");
            box2.DisplayDetails();

            Console.WriteLine("Details of Box-3:");
            box3.DisplayDetails();

            Console.Read();
        }
    }
}
