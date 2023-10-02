using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultNum;
            string operation, answer;

            for ( int i = 0; ; i++)
            {
                Console.Write("Enter the first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the operation: ");
                operation = Convert.ToString(Console.ReadLine());

                Console.Write("Enter the second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                if (operation == "+")
                {
                    resultNum = num1 + num2;
                    Console.WriteLine("Result : {0} {1} {2} = {3}", num1, operation, num2, resultNum);
                }

                else if (operation == "-")
                {
                    resultNum = num1 - num2;
                    Console.WriteLine("Result : {0} {1} {2} = {3}", num1, operation, num2, resultNum);
                }

                else if (operation == "*")
                {
                    resultNum = num1 * num2;
                    Console.WriteLine("Result : {0} {1} {2} = {3}", num1, operation, num2, resultNum);
                }

                else if (operation == "/")
                {
                    resultNum = num1 / num2;
                    Console.WriteLine("Result: {0} {1} {2} = {3}", num1, operation, num2, resultNum);
                }

                Console.Write("Pres 'e' to exit: ");
                answer = Convert.ToString(Console.ReadLine());
                if (answer == "e")
                {
                    Environment.Exit(0);
                }
            }                     
                                             
        }
    }
}
