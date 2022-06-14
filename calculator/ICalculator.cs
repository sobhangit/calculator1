using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    interface ICalculator
    {
        void calculate(int num1, int num2, string op);
        int sum(int number1, int number2);
        int minus(int number1, int number2);
        int multiply(int number1, int number2);
        int divide(int number1, int number2);
        void showResult();
        void cleanCalculator();
    }
}
