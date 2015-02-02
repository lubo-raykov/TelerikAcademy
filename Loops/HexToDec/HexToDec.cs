//Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:

//hexadecimal	decimal
//FE	        254
//1AE3	        6883
//4ED528CBB4	338583669684

using System;


class HexToDec
{
    static void Main()
    {
        System.Console.WriteLine("Enter hexadecimal code:");
        string binary = Console.ReadLine();

        //string binary = "FE";
        //string binary = "1AE3";
        //string binary ="4ED528CBB4"; 

        ulong number = 0;
        int tempDigit=0;
        double addOn;

        int length = binary.Length;

        for (int i = 0; i < length; i++)
        {
           
            switch (binary[i])
            {
                case '0': tempDigit = 0;
                    break;
                case '1': tempDigit = 1;
                    break;
                case '2': tempDigit = 2;
                    break;
                case '3': tempDigit = 3;
                    break;
                case '4': tempDigit = 4;
                    break;
                case '5': tempDigit = 5;
                    break;
                case '6': tempDigit = 6;
                    break;
                case '7': tempDigit = 7;
                    break;
                case '8': tempDigit = 8;
                    break;
                case '9': tempDigit = 9;
                    break;
                case 'A': tempDigit = 10;
                    break;
                case 'B': tempDigit = 11;
                    break;
                case 'C': tempDigit = 12;
                    break;
                case 'D': tempDigit = 13;
                    break;
                case 'E': tempDigit = 14;
                    break;
                case 'F': tempDigit = 15;
                    break;
            }

            addOn = Math.Pow(16, (double)((length - 1) - i));

            number = number + (ulong)tempDigit * (ulong)addOn;

        }

        Console.WriteLine(number);
    }
}

