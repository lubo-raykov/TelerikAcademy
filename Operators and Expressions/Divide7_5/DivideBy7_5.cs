/*
 * Divide by 7 and 5

    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
    Examples:

    n	Divided by 7 and 5?
    3	false
    0	false
    5	false
    7	false
    35	true
    140	true
 */

using System;


class DivideBy7_5
{
    static void Main()
    {
        bool isDevidable = false;
        Console.WriteLine("Enter number to check:");
        string input = Console.ReadLine();
        int intToCheck = Convert.ToInt32(input);
       
        if (intToCheck % 35 == 0) //this is true condition as 5 and 7 are both primes 
        {
            isDevidable = true;
        }

        Console.WriteLine("{0} is devidable both to 5 and 7: {1}", intToCheck, isDevidable);
    }
}

