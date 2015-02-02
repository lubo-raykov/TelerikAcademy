//Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

//Examples:

//a	        b	    c	    result
//5	        1	    2	    5 2 1
//-2	    -2	    1	    1 -2 -2
//-2	    4	    3	    4 3 -2
//0	        -2.5	5	    5 0 -2.5
//-1.1	    -0.5	-0.1	-0.1 -0.5 -1.1
//10	    20	    30	    30 20 10
//1	        1	    1	    1 1 1

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

        Console.Write("Enter a number: ");
        double num1 = ToLegitNumber(Console.ReadLine());
        Console.Write("Enter a number: ");
        double num2 = ToLegitNumber(Console.ReadLine());
        Console.Write("Enter a number: ");
        double num3 = ToLegitNumber(Console.ReadLine());

        if (num1<num2)
        {
            if (num2<num3)
            {
                Console.WriteLine(num3 + " " + num2 + " " + num1);
            }
            else
            {
                Console.Write(num2 + " ");
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " " + num3);
                }
                else
                {
                    Console.WriteLine(num3 + " " + num1);
                }
            }
        } // num1>num2
        else
        {
            if (num1 < num3)
            {
                Console.WriteLine(num3 + " " + num1 + " " + num2);
            }
            else
            {
                Console.Write(num1 + " ");
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + " " + num3);
                }
                else
                {
                    Console.WriteLine(num3 + " " + num2);
                }
            }
        }
    }
}

