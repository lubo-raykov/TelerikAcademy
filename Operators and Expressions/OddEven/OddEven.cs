/*
 * Write an expression that checks if given integer is odd or even.
Examples:

n	Odd?
3	true
2	false
-2	false
-1	true
0	false
 */

using System;

class OddEven
{
    static void Main()
    {
        int varToCheck;
        bool isOdd = false;
        
        Console.WriteLine("Enter Variable to check if it is odd:");
        string input = Console.ReadLine();

        varToCheck = Convert.ToInt32(input);
        if (varToCheck % 2 != 0)
        {
            isOdd = true;
        }

        Console.WriteLine("{0} is odd: {1}", varToCheck, isOdd);
    }
}

