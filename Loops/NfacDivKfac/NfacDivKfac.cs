//Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
//Examples:

//n	k	n! / k!
//5	2	60
//6	5	6
//8	3	6720

using System;


class NfacDivKfac
{
    static void Main()
    {
        Console.Write("n=");
        ulong n = ulong.Parse(Console.ReadLine());
        Console.Write("k=");
        ulong k = ulong.Parse(Console.ReadLine());
       
        double sum = 1;
        for (ulong i = k + 1; i <= n; i++)
        {
            sum *= i;
        }
        
        Console.WriteLine(sum);
    }
}
