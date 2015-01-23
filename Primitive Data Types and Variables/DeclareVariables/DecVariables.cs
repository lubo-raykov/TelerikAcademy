using System;


class DecalreVaribles
{
    /*
     * declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
 Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
     */


    static void Main()
    {
        ushort variable1 = 52130;
        sbyte variable2 = -115;
        int variable3 = 4825932;
        byte variable4 = 97;
        short variable5 = -10000;

        Console.WriteLine(variable1);
        Console.WriteLine(variable2);
        Console.WriteLine(variable3);
        Console.WriteLine(variable4);
        Console.WriteLine(variable5);
    }
}

