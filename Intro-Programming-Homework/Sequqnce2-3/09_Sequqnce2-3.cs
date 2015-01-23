using System;


class Sequence
{
    static void Main()
    {
        /*
        Problem 9. Print a Sequence

        Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
         */


        //I use a loop with starting value of 2 and ending at 11 
        for (int i = 2; i < 12; i++)
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
            if (i != 11)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

