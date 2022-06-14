using System;
using calculator;

Console.WriteLine("Calculator [ + , - , * , / ]");
Console.WriteLine();

int number2;
string operate;
bool isCleanCalculator = true;

Calculator cal = new Calculator();

while (true)
{
    if (isCleanCalculator)
    {
        cal.Number1 = getNumber();
        isCleanCalculator = false;
    }

    operate = getOperator();

    if (operate == "=")
    {
        cal.cleanCalculator();
        break;
    }

    number2 = getNumber();

    cal.calculate(cal.Number1, number2, operate);
    cal.showResult();
}

isCleanCalculator = true;

static int getNumber()
{
    string userInput;
    int number = 0;

    Console.Write("enter a integer number : ");
    userInput = Console.ReadLine();

    if (string.IsNullOrEmpty(userInput))
    {
        number = getNumber();
    }
    else
    {
        if (int.TryParse(userInput, out number))
        {
            number = int.Parse(userInput);
        }
        else
        {
            number = getNumber();
        }
    }

    return number;
}

static string getOperator()
{
    string operate;

    Console.Write("enter a operator : ");
    operate = Console.ReadLine();

    if (string.IsNullOrEmpty(operate))
    {
        operate = getOperator();
    }
    else
    {
        switch (operate)
        {
            case "+":
                return operate;
            case "-":
                return operate;
            case "*":
                return operate;
            case "/":
                return operate;
            case "=":
                return operate;
            default:
                operate = getOperator();
                break;
        }
    }

    return operate;
}
