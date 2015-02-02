//railing Zeroes in N!

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.
//Examples:

//n	        trailing zeroes of n!	explaination
//10	    2	                    3628800
//20	    4	                    2432902008176640000
//100000	24999	                think why

using System;
using System.Numerics;


class TrailingZeroes
{
    //for 100000 is realy slow
    static void Main()
    {
        Console.Write("n=");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger result = 1;
        long br = 0;
        char sign = '0';
        for (int i = 2; i <= n; i++)
        {
            result = result * i; 
        }
        //Console.WriteLine(result);
        //ok
        
        string factoriel = result.ToString();
        int lenght = factoriel.Length;
        //Console.WriteLine(lenght);

            for (int i = lenght-1; sign == '0'; i--)
            {
                if (factoriel[i] == '0')
                {
                    br++;
                    sign = factoriel[i];
                }
                else
                {
                    break;
                }
            }

        Console.WriteLine(br);
    }
}

