//Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
//Examples:

//numbers	sum
//3	        90
//  20	
//  60	
//  10	
//5	        6.5
//  2	
// -1	
// -0.5	
//  4	
//  2	
//1	        1
//  1

using System;
using System.Globalization;
using System.Threading;


class PrintNNumbers
{
    static double IsNumber(string number)
    {
        bool test = true;
        double result;
        do
        {
            test = double.TryParse(number, out result);
            if (test == false)
            {
                Console.Write("Not Legid! Enter again: ");
                number = Console.ReadLine();
            }
        } while (test != true);

        return result;
    }

    static double ToLegitNumber(string number)
    {
        string newString = number.Replace(',', '.');
        return IsNumber(newString);
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0d;
        string myNumber;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("enter number No.{0}: ",i);
            myNumber = Console.ReadLine();
            sum += ToLegitNumber(myNumber);
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}
