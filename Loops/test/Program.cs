using System;



class Program
{
    static void Main()
    {
        int fak = 1;
        for (int i = 2; i < 10; i++)
        {
            fak *= i;
        }
        Console.WriteLine(fak);
    }
}
