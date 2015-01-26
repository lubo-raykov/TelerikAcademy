//Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

//Examples:

//n	    comments
//1	    0
//3	    0 1 1
//10	0 1 1 2 3 5 8 13 21 34

using System;


    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Enter n: ");  // accurate upto n=998
            ushort n = ushort.Parse(Console.ReadLine());

            ulong[] fibunacci = new ulong[n];
            fibunacci[0] = 0;
            
            if (n == 1)
            {
                Console.WriteLine(fibunacci[0]);
                return;
            }

            if (n == 2)
            {
                fibunacci[1] = 1;
                Console.WriteLine("{0}, {1}", fibunacci[0], fibunacci[1]);
            }
            else
            {
                fibunacci[1] = 1;
                Console.Write("{0}, {1}, ", fibunacci[0], fibunacci[1]);
                for (int i = 2; i < n-1; i++)
                {
                    fibunacci[i] = fibunacci[i - 2] + fibunacci[i - 1];
                    Console.Write(fibunacci[i] + ", ");
                }
                fibunacci[n-1] = fibunacci[n - 3] + fibunacci[n - 2];
                Console.WriteLine(fibunacci[n-1]);
            }
            

        }
    }

