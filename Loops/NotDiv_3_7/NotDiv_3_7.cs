//Numbers Not Divisible by 3 and 7

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
//Examples:

//n	output
//3	1 2
//10	1 2 4 5 8 10


using System;



    class NotDiv_3_7
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i%3 == 0 || i%7 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write("{0} ", i);
                }
            }
            
            if ((n % 3 != 0) && (n % 7 != 0))
            {
                Console.WriteLine("{0}", n);
            }
        }
    }

