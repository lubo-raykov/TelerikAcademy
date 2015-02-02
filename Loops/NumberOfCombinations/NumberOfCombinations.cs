//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
//Examples:

//n	    k	n! / (k! * (n-k)!)
//3	    2	3
//4	    2	6
//10	6	210
//52	5	2598960

using System;



class NumberOfCombinations
{
    static void Main()
    {
        Console.Write("n=");
        double n = double.Parse(Console.ReadLine());
        Console.Write("k=");
        double k = double.Parse(Console.ReadLine());
        double nMinusK = n - k;
        double sum = 1;
        double nFac = 1;
        double kFac = 1;
        double nKFac = 1;
        for (int i = 2; i <= n; i++)
        {
            nFac *= i;
            if (i<=k)
            {
                kFac *= i;
            }
            if (i<= nMinusK)
            {
                nKFac *= i;
            }
        }
        sum = nFac / (kFac * nKFac);
        Console.WriteLine(sum);
    }
}

