//Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
//Examples:

//a	    b	    c	    result
//5	    2	    2	    +
//-2	-2	    1	    +
//-2	4	    3	    -
//0	    -2.5	4	    0
//-1	-0.5	-5.1	-

using System;
using System.Globalization;
using System.Threading;


class MultiplicationSign
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

        double[] numbers = new double[3];
        int zero = 0;
        int minus = 0;
        char character;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number {0}: " , i+1);
            numbers[i] = ToLegitNumber(Console.ReadLine());
            if (numbers[i] == 0)
            {
                zero++;
            }
            else
            {
                if (numbers[i] < 0)
                {
                    minus++;
                }
            }
        }

        if (zero > 0)
        {
            character = '0';
        }
        else
        {
            if (minus % 2 == 0)
            {
                character = '+';
            }
            else
            {
                character = '-';
            }
        }
        Console.WriteLine(character);
    }
}

