using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculator : ICalculator
    {
        private int _number1;
        private int _number2;
        string operate = string.Empty;

        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Operate { get; set; }

        public void calculate(int num1, int num2, string op)
        {
            switch (op)
            {
                case "+":
                    _number1 = sum(num1, num2);
                    break;
                case "-":
                    _number1 = minus(num1, num2);
                    break;
                case "*":
                    _number1 = multiply(num1, num2);
                    break;
                case "/":
                    _number1 = divide(num1, num2);
                    break;
                case "=":
                    showResult();
                    break;
            }

        }

        public int sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int minus(int number1, int number2)
        {
            return number1 - number2;
        }

        public int multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int divide(int number1, int number2)
        {
            return number1 / number2;
        }

        public void showResult()
        {
            Console.WriteLine("result : {0}", _number1);
        }

        public void cleanCalculator()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            showResult();
            _number1 = 0;
            Console.ResetColor();
        }

    }
}
