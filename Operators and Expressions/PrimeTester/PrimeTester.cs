/*
 * Prime Number Check

    Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
    Examples:

    n	Prime?
    1	false
    2	true
    3	true
    4	false
    9	false
    97	true
    51	false
    -3	false
    0	false
 */

using System;

    class PrimeTester
    {
        //separate function in order to copy paste from now on :)
        static bool IsPrime(int number)
        {
        bool isPrime = true;
        //primary trow-false
        if (number <= 0 || number == 1)
        {
            return false;
        }
        //searching trought posible values of dividers
        for (int i = 2; i <= (int)Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return isPrime;
        }

        
        static void Main()
        {
            Console.WriteLine("Enter number to check");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            bool result = IsPrime(number);  //calling the method IsPrime with argument number
            Console.WriteLine("The number is prime: " + result);
        }
    }

