//Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal	binary
//0	        0
//3	        11
//43691	    1010101010101011
//236476736	1110000110000101100101000000

using System;
using System.Collections;


class DecimalToBin
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number: ");
        long number = long.Parse(Console.ReadLine());
        Stack binary = new Stack();
        long digit;

        do
        {
            digit = number % 2;
            binary.Push(digit);
            number /= 2;
        } while (number!=0);

        int br = binary.Count;

        for (int i = 0; i < br; i++)
        {
            Console.Write(binary.Pop());
        }
        Console.WriteLine();
    }
}

