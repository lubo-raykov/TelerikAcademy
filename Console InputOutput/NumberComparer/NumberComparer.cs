//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
//Examples:

//a	b	greater
//5	6	6
//10	5	10
//0	0	0
//-5	-2	-2
//1.5	1.6	1.6

using System;
using System.Globalization;
using System.Threading;

class NumberComparer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter first number:");
        string first = Console.ReadLine();
        first = first.Replace(',', '.');
        double firstDouble;
        bool isNumber = double.TryParse(first, out firstDouble);
        if (isNumber == false)
        {
            Console.WriteLine("This is not a legit number!");
            return;
        }

        Console.WriteLine("Enter second number:");
        string second = Console.ReadLine();
        first = second.Replace(',', '.');
        double secondDouble;
        isNumber = double.TryParse(first, out secondDouble);
        if (isNumber == false)
        {
            Console.WriteLine("This is not a legit number!");
            return;
        }

        Console.WriteLine(firstDouble > secondDouble ? firstDouble : secondDouble);

    }
}

