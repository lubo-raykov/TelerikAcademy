//Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal	hexadecimal
//254	FE
//6883	1AE3
//338583669684	4ED528CBB4

using System;
using System.Collections;


class DecimalToHex
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number: ");
        long number = long.Parse(Console.ReadLine());
        Stack hex = new Stack();
        long temp;
        char character= '@';

        do
        {
            temp = number % 16;

            switch (temp)
            {
                case 0: character = '0';
                    break;
                case 1: character = '1';
                    break;
                case 2: character = '2';
                    break;
                case 3: character = '3';
                    break;
                case 4: character = '4';
                    break;
                case 5: character = '5';
                    break;
                case 6: character = '6';
                    break;
                case 7: character = '7';
                    break;
                case 8: character = '8';
                    break;
                case 9: character = '9';
                    break;
                case 10: character = 'A';
                    break;
                case 11: character = 'B';
                    break;
                case 12: character = 'C';
                    break;
                case 13: character = 'D';
                    break;
                case 14: character = 'E';
                    break;
                case 15: character = 'F';
                    break;
            }

            hex.Push(character);
            number /= 16;
        } while (number != 0);

        int br = hex.Count;

        for (int i = 0; i < br; i++)
        {
            Console.Write(hex.Pop());
        }
        Console.WriteLine();
    }
}

