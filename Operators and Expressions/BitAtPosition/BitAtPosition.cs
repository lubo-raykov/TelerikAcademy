﻿/*
 * Extract Bit from Integer

    Write an expression that extracts from given integer n the value of given bit at index p.
    Examples:

    n	binary representation	p	bit @ p
    5	00000000 00000101	2	1
    0	00000000 00000000	9	0
    15	00000000 00001111	1	1
    5343	00010100 11011111	7	1
    62241	11110011 00100001	11	0
 */

using System;


class BitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Write your number:");
        string input = Console.ReadLine();
        int testNumber = Convert.ToUInt16(input);

        Console.WriteLine("Write position of the bit:");
        input = Console.ReadLine();
        int position = Convert.ToUInt16(input);

        int mask = 1 << position;        
        int nAndMask = testNumber & mask;
        int bit = nAndMask >> position;
        Console.WriteLine(bit);
    }
}

