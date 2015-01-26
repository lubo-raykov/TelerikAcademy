//Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//Examples:

//numbers	        sum
//1 2 3 4 5	        15
//10 10 10 10 10	50
//1.5 3.14 8.2 -1   11.84


using System;
using System.Globalization;
using System.Threading;



class SumOf5
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        Console.WriteLine("Enter 5 number sequence: ");
        string myNumbers = Console.ReadLine();
        string[] myArray = myNumbers.Split(' ');
        double sum = 0;
        foreach (var item in myArray)
        {
            sum += double.Parse(item);   
        }
        Console.WriteLine(sum);
    }
}
