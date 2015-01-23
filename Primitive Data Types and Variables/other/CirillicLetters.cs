using System;
using System.Collections.Generic;
using System.Text;

public class CirillicLetters
{

    public static void Main()
    {
        char c;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Cirillic letters:");
        for (int i = 1040; i <= 1103; i++)
        {
            c = (char)i;
            Console.WriteLine(i + " -> " + c);

        }
    }
}
