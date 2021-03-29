using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter 2 numbes");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Which operation would you like to use?");

            string input = Console.ReadLine();

            string plus = "+";
            string minus = "-";
            string divide = "/";
            string multiply = "*";

            if (plus == input)
            {
                int result = num1 + num2;
                Console.WriteLine("The result is: " + result);
            }

            if (minus == input)
            {
                int result = num1 - num2;
                Console.WriteLine("The result is: " + result);
            }

            if (divide == input)
            {
                int result = num1 / num2;
                Console.WriteLine("The result is: " + result);
            }

            if (multiply == input)
            {
                int result = num1 * num2;
                Console.WriteLine("The result is: " + result);
            }
        }
    }
}
