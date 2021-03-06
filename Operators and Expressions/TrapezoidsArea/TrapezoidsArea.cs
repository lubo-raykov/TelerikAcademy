﻿/*
 * Trapezoids
    Write an expression that calculates trapezoid's area by given sides a and b and height h.
    Examples:

    a	b	h	area
    5	7	12	72
    2	1	33	49.5
    8.5	4.3	2.7	17.28
    100	200	300	45000
    0.222	0.333	0.555	0.1540125
 */

using System;


class TrapezoidsArea
{
    static void Main()
    {
        //NOTE: according to system settings of every computer
        //      floating point format can be entered with '.' or ',' the odd will crash 
        
        Console.WriteLine("Enter base1");
        string input = Console.ReadLine();
        double area = Convert.ToDouble(input);  //area is base1
        Console.WriteLine("Enter base2");
        input = Console.ReadLine();
        area += Convert.ToDouble(input);        //area = base1 + base2
        Console.WriteLine("Enter height");
        input = Console.ReadLine();
        area *= Convert.ToDouble(input);        //area = (base1 + base 2) * height
        area /= 2;                              //area = (base1 + base 2) * height / 2
        Console.WriteLine("The area of the trapezoid is " + area);
    }
}

