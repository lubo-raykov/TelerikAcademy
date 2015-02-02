//Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: (2n)! / ((n+1)!*n!)
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
//Examples:

//n	Catalan(n)
//0	1
//5	42
//10	16796
//15	9694845

using System;


    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("n=");
            double n = double.Parse(Console.ReadLine());
            double twoN = n * 2;
            double nPlus = n + 1;

            double nFac = 1;
            double nTwoFac = 1;
            double nPlusFac = 1;

            for (int i = 2; i <= twoN; i++)
            {
                nTwoFac *= i;
                if (i<=n)
                {
                    nFac *= i; 
                }
                if (i<= nPlus)
                {
                    nPlusFac *= i; 
                }
            }
            double result = nTwoFac / (nPlusFac * nFac);
            Console.WriteLine(result);
            
        }
    }

