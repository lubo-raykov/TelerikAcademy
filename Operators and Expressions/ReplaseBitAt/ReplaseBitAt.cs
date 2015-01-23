/*
 * Modify a Bit at Given Position

    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
    Examples:

    n	    binary representation of n	p	v	binary result	        result
    5	    0000 0000 0000 0101	        2	0	0000 0000 0000 0001	    1
    0	    0000 0000 0000 0000	        9	1	0000 0010 0000 0000	    512
    15	    0000 0000 0000 1111	        1	1	0000 0000 0000 1111	    15
    5343	0001 0100 1101 1111	        7	0	0001 0100 0101 1111	    5215
    62241	1111 0011 0010 0001	        11	0	1111 0011 0010 0001	    62241
 */

using System;


class IfBitIs
{
    static void Main()
    {
        Console.WriteLine("Write your number:");
        string input = Console.ReadLine();
        int testNumber = Convert.ToUInt16(input);

        Console.WriteLine("Write position of the bit:");
        input = Console.ReadLine();
        int position = Convert.ToUInt16(input);

        Console.WriteLine("What should be the value ot this bit:");
        input = Console.ReadLine();
        int value = Convert.ToUInt16(input);

        int mask = 1 << position;
        int nAndMask = testNumber & mask;
        int bit = nAndMask >> position;
        if (bit != value)
	    {
            if (value == 0)
            {                 
                mask = ~(1 << position);
                int result = testNumber & mask; 
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
                Console.WriteLine(result);
            }
            else //value ==1
            {
                mask = 1 << position;
                int result = testNumber | mask;      
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
                Console.WriteLine(result);
            }
	    } 
        else //bit==value 
        {
            Console.WriteLine(Convert.ToString(testNumber, 2).PadLeft(16, '0'));
            Console.WriteLine(testNumber);
        }
    }
}

