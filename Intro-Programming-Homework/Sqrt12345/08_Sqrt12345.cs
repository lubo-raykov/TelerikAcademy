using System;



class Sqrt12345
{
    static void Main()
    {
        /*
         Problem 8. Square Root

        Create a console application that calculates and prints the square root of the number 12345.
        Find in Internet “how to calculate square root in C#”.
         */
        
        Console.WriteLine("The square root of 12345 is");
        Console.WriteLine(Math.Sqrt(12345));                    //default precision
        Console.WriteLine("or with less precison");
        Console.WriteLine(Math.Round(Math.Sqrt(12345),2));      //with precision of 2 charaktes after the decimal point

    }
}

