using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_08
{
    public class Triangle : IShape
    {
        int a = 3;
        int b = 6;
        int c = 5;
        public string GetShapeType()
        {
            return "Triangle";
        }

        public double GetShapeArea()
        {
            return a * b * c ;
        }

        public double GetPerimeter()
        {
            return a*b + b*c + c*a;
        }

    }
}
