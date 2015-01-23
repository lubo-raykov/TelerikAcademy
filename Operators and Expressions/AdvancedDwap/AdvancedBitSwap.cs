/*
 * Bit Exchange (Advanced)

    Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
    The first and the second sequence of bits may not overlap.
    Examples:

            n	p	q	k	binary representation of n	        binary result	                    result
    1140867093	3	24	3	01000100 00000000 01000000 00010101	01000010 00000000 01000000 00100101	1107312677
    4294901775	24	3	3	11111111 11111111 00000000 00001111	11111001 11111111 00000000 00111111	4194238527
    2369124121	2	22	10	10001101 00110101 11110111 00011001	01110001 10110101 11111000 11010001	1907751121
    987654321	2	8	11	-	-	overlapping
    123456789	26	0	7	-	-	out of range
    33333333333	-1	0	33	-	-	out of range
 */
using System;

class AdvancedSwap
{
    static void Main()
    {
        //entry
        Console.WriteLine("Enter the number:"); 
        string input = Console.ReadLine();      
        uint number;
        if (!uint.TryParse(input, out number))
        {
            Console.WriteLine("out of range");
            return;
        }

        Console.WriteLine("Enter P value:");
        int pos1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Q value:");
        int pos2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter K value:");
        int distance = int.Parse(Console.ReadLine());

        int pBitsUpper = pos1 + distance - 1;     //uper limit of bits index to be exjanged from p
        int qBitsUpper = pos2 + distance - 1;     //uper limit of bits index to be exjanged from q


        //validation stage 1 -> out of range of bits 0-31
        if (pos1 < 0 || pos2 > 31)
        {
            Console.WriteLine("out of range");
            return;
        }
        if (pos1 < 0 || pos2 > 31)
        {
            Console.WriteLine("out of range");
            return;
        }
        if (pBitsUpper < 0 || pBitsUpper > 31)
        {
            Console.WriteLine("out of range");
            return;
        }
        if (qBitsUpper < 0 || qBitsUpper > 31)
        {
            Console.WriteLine("out of range");
            return;
        }

        //validation stage 2 -> overlapping (5 7) (6 8)
        if ((pos1 == pos2) || (pos1 < pos2 && pBitsUpper >= pos2) || (pos2 < pos1 && qBitsUpper >= pos1))
        {
            Console.WriteLine("overlapping");
            return;
        }

        //mask by distance
        uint mask = Convert.ToUInt32(Math.Pow(2.0, (double)distance) - 1);

        /*
        Console.WriteLine("mask is "+ mask);
        string binary = Convert.ToString(mask, 2);
        Console.WriteLine(binary);
        */

        //placing the masks for givven positions
        uint mask1 = mask;
        mask1 = mask1 << pos1;
        uint mask2 = mask;
        mask2 = mask2 << pos2;

        //colecting bit samples in temp values
        uint temp1 = number & mask1;
        uint temp2 = number & mask2;
        
        //setting zero bits to given positions
        number = number & ~mask1;
        number = number & ~mask2;

        //calculating the offset between first position and second position
        int offset = (int)Math.Abs(pos1-pos2);
        
        //mooving the sample bits
        if (pos1 > pos2)
        {
            temp1 = temp1 >> offset;
            temp2 = temp2 << offset;
        }
        else
        {
            temp1 = temp1 << offset;
            temp2 = temp2 >> offset;
        }

        //setting the bit sampes to the zero-setted positions vise-versa
        number = number | temp1;
        number = number | temp2;

        Console.WriteLine(number);
    }
}

