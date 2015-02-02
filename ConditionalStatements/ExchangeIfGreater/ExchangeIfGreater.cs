//Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
//Examples:

//a	    b	    result
//5	    2	    2 5
//3	    4	    3 4
//5.5	4.5	    4.5 5.5

using System;
using System.Globalization;
using System.Threading;


class ExchangeIfGreater
{
    static double IsNumber(string number)
    {
        bool test = true;
        double result;
        do
        {
            test = double.TryParse(number, out result);
            if (test == false)
            {
                Console.Write("Not Legid! Enter again: ");
                number = Console.ReadLine();
            }
        } while (test != true);

        return result;
    }

    static double ToLegitNumber(string number)
    {
        string newString = number.Replace(',', '.');
        return IsNumber(newString);
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter the first number: ");
        double firstNum = ToLegitNumber(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNum = ToLegitNumber(Console.ReadLine());

        if (firstNum > secondNum)
        {
            double bufer = secondNum;
            secondNum = firstNum;
            firstNum = bufer;
        }

        Console.WriteLine("{0} {1}", firstNum, secondNum);
    }
}
