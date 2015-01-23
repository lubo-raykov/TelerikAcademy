using System;
using System.Collections.Generic;
using System.Text;

class AsciiTable
{
    /*
     * Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
       Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
     */

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        char c;
        for (int i = 0; i < 65535; i++)
        {
            c = (char)i;
            if (char.IsSymbol(c) || char.IsLetter(c) || char.IsNumber(c) || (c >= 1 && c <= 6) || (c >= 11 && c <= 31 && c!=13))  
            {
                Console.WriteLine(i + " is: " + (char)i); 
            }
            
        }   
    }
}

