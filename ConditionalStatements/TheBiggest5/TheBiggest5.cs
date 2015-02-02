//The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.
//Examples:

//a 	b	    c	    d	    e	    biggest
//5	    2	    2	    4	    1	    5
//-2	-22	    1	    0	    0	    1
//-2	4	    3	    2	    0	    4
//0	    -2.5	0	    5	    5	    5
//-3	-0.5	-1.1	-2	    -0.1	-0.1

using System;
using System.Globalization;
using System.Threading;


class TheBiggest5
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

        double maxNum = double.MinValue;
        double num;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter real number: ");
            num = ToLegitNumber(Console.ReadLine());
            if (num > maxNum)
            {
                maxNum = num;
            }
        }

        Console.WriteLine(maxNum);

    }
}
