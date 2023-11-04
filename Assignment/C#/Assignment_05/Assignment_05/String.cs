using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    class String
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            
            Console.WriteLine("Enter a letter to count:");
            char lettertocount = Console.ReadLine()[0];

            int count = NumberOfOccurences(str, lettertocount);
            Console.WriteLine(value: $"The letter '{lettertocount}' appears {count} times in the string ");
        }

        static int NumberOfOccurences(string str, char lettertocount)
        {
            int count = 0;
            foreach(char c in str)
            {
                if(c==lettertocount)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
