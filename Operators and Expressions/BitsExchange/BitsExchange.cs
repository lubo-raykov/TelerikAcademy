/*
 * Bits Exchange

Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
Examples:

n	binary representation of n	binary result	result
1140867093	01000100 00000000 01000000 00010101	01000010 00000000 01000000 00100101	1107312677
255406592	00001111 00111001 00110010 00000000	00001000 00111001 00110010 00111000	137966136
4294901775	11111111 11111111 00000000 00001111	11111001 11111111 00000000 00111111	4194238527
5351	00000000 00000000 00010100 11100111	00000100 00000000 00010100 11000111	67114183
2369124121	10001101 00110101 11110111 00011001	10001011 00110101 11110111 00101001	2335569705
 */

using System;



class BitsExchange
{
    static uint GetValueAt(uint number, int position)
    {
        uint mask = Convert.ToUInt32(1 << position);
        uint numberAndMask = number & mask;
        uint bit = numberAndMask >> position;
        return bit;
    }

    static uint PutBitAt(uint number, uint bit, int position)
    {
        uint bitBeChanged = GetValueAt(number,position);
        if (bit != bitBeChanged)
        {
            if (bit == 0)
            {
                uint mask = ~Convert.ToUInt32(1 << position);       
                number = number & mask;       
            }
            else
            {
                uint mask = Convert.ToUInt32(1 << position);          
                number = number | mask;      
            }
        }
    return number;
    }
    

    static void Main()
    {
        Console.WriteLine("Enter the number:");
        string input = Console.ReadLine();
        uint number = Convert.ToUInt32(input);

        uint bitAt3 = GetValueAt(number, 3);
        uint bitAt4 = GetValueAt(number, 4);
        uint bitAt5 = GetValueAt(number, 5);
        uint bitAt24 = GetValueAt(number, 24);
        uint bitAt25 = GetValueAt(number, 25);
        uint bitAt26 = GetValueAt(number, 26);

        number = PutBitAt(number, bitAt3, 24);
        number = PutBitAt(number, bitAt4, 25);
        number = PutBitAt(number, bitAt5, 26);
        number = PutBitAt(number, bitAt24, 3);
        number = PutBitAt(number, bitAt25, 4);
        number = PutBitAt(number, bitAt26, 5);

        Console.WriteLine(number);
    }
}

