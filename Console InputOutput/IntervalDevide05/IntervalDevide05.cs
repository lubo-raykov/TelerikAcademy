﻿//Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
//Examples:

//start	end	p	comments
//17	25	2	20, 25
//5	    30	6	5, 10, 15, 20, 25, 30
//3	    33	6	5, 10, 15, 20, 25, 30
//3	    4	0	-
//99	120	5	100, 105, 110, 115, 120
//107	196	18	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195

using System;


class IntervalDevide05
{
    static ulong ValidNumber(string stringToPharse)
    {
        bool underZero;
        ulong number;
        underZero = ulong.TryParse(stringToPharse, out number);
        if (underZero == false)
        {
            do
            {
                Console.Write("Enter correct value: ");
                underZero = ulong.TryParse(Console.ReadLine(), out number);

            } while (underZero != true);
        }
        return number;
    }

    static void Main()
    {
        
        Console.Write("Enter 1-st positive number(greater than 0): ");
        string stringNum = Console.ReadLine();
        ulong first = ValidNumber(stringNum);

        Console.Write("Enter 2-st positive number(greater than 0): ");
        stringNum = Console.ReadLine();
        ulong second = ValidNumber(stringNum);

        if (first == 0 || second == 0)
        {
            Console.WriteLine("Error 0 is not \"positive\"");
            return;
        }

        if (second < first)
        {
            ulong temp = first;
            first = second;
            second = first;
        }

        ulong div1 = first / 5;
        ulong div2 = second / 5;


        Console.WriteLine((first % 5 == 0 && second % 5 == 0)? div2 - div1+1 : div2 - div1);
    }
}

