using System;



class LongSequance
{
    static void Main()
    {
        /*
         Problem 16.* Print Long Sequence

        Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
        You might need to learn how to use loops in C# (search in Internet).
         */


        //I use a loop with starting value of 2 and ending at 1001 
        for (int i = 2; i < 1002; i++)
        {
            // if-else construction to find out odds 
            // %2 is used to check if the number is divisible by 2
            if (i % 2 == 0)
            {
                Console.Write(i);
            }
            else
            {
                Console.Write(-1 * i);
            }

            // this puts space between sequence members except after the last
            if (i != 1001)
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();

    }
}

