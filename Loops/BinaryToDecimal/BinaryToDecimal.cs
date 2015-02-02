//Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:

//binary	                             decimal
//0	                                     0
//11	                                 3
//1010 1010 1010 1011	                 43691
//1110 0001 1000 0101 1001 0100 0000	 236476736

using System;



class BinaryToDecimal
{
    static void Main()
    {
        System.Console.WriteLine("Enter binnary code:");
        string binary = Console.ReadLine();
        
        //string binary = "1010101010101011";
        //string binary ="1110000110000101100101000000"; 

        long number = 0;
        int tempDigit;
        double addOn;

        int length = binary.Length;

        for (int i = 0; i < length; i++)
        {
            tempDigit = int.Parse(binary[i].ToString());

            //ok
            addOn = Math.Pow(2, (double)((length-1)-i));


            number = number + (long)tempDigit * (long)addOn;

        }

        Console.WriteLine(number);
    }

}

