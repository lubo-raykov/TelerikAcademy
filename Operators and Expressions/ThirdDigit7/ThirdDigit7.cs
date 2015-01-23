/*
 * Third Digit is 7?

    Write an expression that checks for given integer if its third digit from right-to-left is 7.
    Examples:

    n	Third digit 7?
    5	false
    701	true
    9703	true
    877	false
    777877	false
    9999799	true
 */

using System;


class ThirdDigit7
{
    static void Main()
    {
        bool isThird7 = false;
        Console.WriteLine("Enter number to check:");
        string input = Console.ReadLine();
        int numToCheck = Convert.ToInt32(input);
        numToCheck /= 100;
        if (numToCheck % 10 == 7)
        {
            isThird7 = true;
        }

        Console.WriteLine("The 3-rd digit from right ot left is 7: {0}", isThird7);
    }
}

