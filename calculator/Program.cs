using System;
using calculator;

Console.WriteLine("Calculator [ + , - , * , / ]");
Console.WriteLine();

Calculator cal = new Calculator();

bool runCalculator = true;
bool isCleanCalculator = true;

while (runCalculator)
{
    while (true)
    {
        if (isCleanCalculator)
        {
            cal.Number1 = getNumber();
            isCleanCalculator = false;
        }

        cal.Operate = getOperator();

        if (cal.Operate == "=")
        {
            cal.cleanCalculator();
            break;
        }

        cal.Number2 = getNumber();

        cal.calculate(cal.Number1, cal.Number2, cal.Operate);
        cal.showResult();
    }

    isCleanCalculator = true;

    Console.WriteLine("Again : Y or N");
    string code = Console.ReadLine();

    if (code == "Y".ToLower() ? runCalculator = true : runCalculator = false) ;
}


int getNumber()
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

string getOperator()
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
