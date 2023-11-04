using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_03
{
    class Cricket
    {
        public void Pointscalculation(int no_of_matches) //Pointscalculation Function
        {
            List<int> scores = new List<int>();                
            int sum = 0;

            for(int i=0; i<no_of_matches;i++)
            {
                Console.WriteLine($"Enter The Score Of Match:{i+1} ");

                if(int.TryParse(Console.ReadLine(), out int score))
                {
                    scores.Add(score);
                    sum += score;
                }
                else
                {
                    Console.WriteLine("Invalid Input.Please Enter a Valid Data!");
                    i--;
                }
            }

            double average = (double)sum / no_of_matches;
            Console.WriteLine($"Sum of scores: {sum}");
            Console.WriteLine($"Average of scores: {average:F2}");

        }
    }
    class Question1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number of IPL Matches You Want To Add:");
            if(int.TryParse(Console.ReadLine(),out int no_of_matches) && no_of_matches >0)
            {
                Cricket cricket = new Cricket();
                cricket.Pointscalculation(no_of_matches);
            }
            else
            {
                Console.WriteLine("Invalid Input. Please Enter a Valid Data! ");
            }

            Console.Read();
        }
    }
}
