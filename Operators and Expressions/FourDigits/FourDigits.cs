/*
 * Four-Digit Number

    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
    Prints on the console the number in reversed order: dcba (in our example 1102).
    Puts the last digit in the first position: dabc (in our example 1201).
    Exchanges the second and the third digits: acbd (in our example 2101).
    The number has always exactly 4 digits and cannot start with 0.

    Examples:

    n	sum of digits	reversed	last digit in front	second and third digits exchanged
    2011	4	        1102	    1201	            2101
    3333	12	        3333	    3333	            3333
    9876	30	        6789	    6987	            9786 
 */

using System;


class FourDigits
{
    static void Main()
    {
        Console.WriteLine("Enter 4-digit number:");
        string input = Console.ReadLine();
        int tempNumber = Convert.ToInt32(input);
        int position4 = tempNumber % 10;
        tempNumber /= 10;
        int position3 = tempNumber % 10;
        tempNumber /= 10;
        int position2 = tempNumber % 10;
        int position1 = tempNumber / 10;
        //test
        // Console.WriteLine("The number is {0}{1}{2}{3}", position1, position2, position3, position4); 
        int sum = position1 + position2 + position3 + position4;
        Console.WriteLine("The sum of the four disgits is " + sum);
        Console.WriteLine("The number backward-written is {3}{2}{1}{0}", position1, position2, position3, position4);
        Console.WriteLine("The number with last digit in front is {3}{0}{1}{2}", position1, position2, position3, position4);
        Console.WriteLine("The number with 2-nd & 3-rd digit swaped is {0}{2}{1}{3}", position1, position2, position3, position4);
    }
}

