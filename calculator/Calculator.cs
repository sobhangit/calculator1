using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculator
    {
        public static int number1 = 0;
        string operate = "";

        public static void calculate(int num1, int num2, string op)
        {
            switch (op)
            {
                case "+":
                    number1 = sum(num1, num2);
                    break;
                case "-":
                    number1 = minus(num1, num2);
                    break;
                case "*":
                    number1 = multiply(num1, num2);
                    break;
                case "/":
                    number1 = divide(num1, num2);
                    break;
                case "=":
                    showResult();
                    break;
            }

        }

        static int sum(int number1, int number2)
        {
            return number1 + number2;
        }

        static int minus(int number1, int number2)
        {
            return number1 - number2;
        }

        static int multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int divide(int number1, int number2)
        {
            return number1 / number2;
        }


        public static void showResult()
        {
            Console.WriteLine("result : {0}", number1);
        }

        public static void cleanCalculator()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            showResult();
            number1 = 0;
            Console.ResetColor();
        }

    }
}
