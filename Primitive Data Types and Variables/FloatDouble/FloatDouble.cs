﻿using System;


class FloatDouble
{
    /*
     * Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.
     */

    static void Main()
    {
        double variable1 = 34.567839023D;
        float variable2 = 12.345F;
        double variable3 = 8923.1234857D;
        float variable4 = 3456.091F;

        Console.WriteLine(variable1);
        Console.WriteLine(variable2);
        Console.WriteLine(variable3);
        Console.WriteLine(variable4);
    }
}
