﻿//Write a program that reads 3 real numbers from the console and prints their sum.
//Examples:
//a	b	c	sum
//3	4	11	18
//-2	0	3	1
//5.5	4.5	20.1	30.1

using System;
using System.Threading;
using System.Globalization;

class SumOf3
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter A value: ");
        double sumOfTree = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter B value: ");
        sumOfTree += double.Parse(Console.ReadLine());
        Console.WriteLine("Enter C value: ");
        sumOfTree += double.Parse(Console.ReadLine());

        Console.WriteLine("The result is: " + sumOfTree);
    }
}

