//Calculate GCD

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).
//Examples:

//a	    b	    GCD(a, b)
//3	    2	    1
//60	40	    20
//5	    -15	    5


using System;


class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter number1: ");
        long num1 = long.Parse(Console.ReadLine());
        Console.Write("Enter number2: ");
        long num2 = long.Parse(Console.ReadLine());
        
        long num1a = Math.Abs(num1);
        long num2a = Math.Abs(num2);

        long min = Math.Min(num1a, num2a);
        long max = Math.Max(num1a, num2a);

        do
        {
            if (max % min == 0)
            {
                Console.WriteLine("GCD of {0} and {1} is {2}",num1,num2,min);
                return;
            }
            else
            {
                num1a = max - ((max / min) * min);
                num2a = min;
                max = Math.Max(num1a, num2a);
                min = Math.Min(num1a, num2a);
            }
        } while (min == max);
        Console.WriteLine("GCD of {0} and {1} is {2}",num1,num2,min);
        
    }
}

