using System;

namespace Test_04
{

    delegate int CalculatorDelegate(int a, int b); // defining delegate
    class Question_02
    {
        static void Main()
        {

            Console.WriteLine("Calculator Methods:");

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");

            Console.Write("Select an operation (1/2/3): ");
            int choice = int.Parse(Console.ReadLine());

            // Defining delegate instances
            CalculatorDelegate calculatorDelegate = null;

            switch (choice)
            {
                case 1:
                    calculatorDelegate = Add;
                    break;

                case 2:
                    calculatorDelegate = Subtract;
                    break;

                case 3:
                    calculatorDelegate = Multiply;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = calculatorDelegate(num1, num2);
            Console.WriteLine("Result: " + result);
            Console.Read();
        }

        // Calculator methods
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}