//Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.
//Examples:

//a	    b	    c	        result
//254	11.6	0.5	        FE      |0011111110|    11.60|0.500     |
//499	-0.5559	10000	    1F3     |0111110011|    -0.56|10000.000 |
//0	    3	    -0.1234	    0       |0000000000|        3|-0.123    |

using System;
using System.Globalization;
using System.Threading;

class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter A number(int)[0-500]: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter B number(flating point): ");
        string first = Console.ReadLine();
        first = first.Replace(',', '.');
        double b;
        bool isNumber = double.TryParse(first, out b);
        if (isNumber == false)
        {
            Console.WriteLine("This is not a legit number!");
            return;
        }

        Console.Write("Enter C number(flating point): ");
        string second = Console.ReadLine();
        first = first.Replace(',', '.');
        double c;
        isNumber = double.TryParse(second, out c);
        if (isNumber == false)
        {
            Console.WriteLine("This is not a legit number!");
            return;
        }

        string aHex = a.ToString("X");
        string aBin0 = Convert.ToString(a, 2);
        string aBin = aBin0.PadLeft(10, '0');
        
        Console.WriteLine("{0,-10}|{1,10:0000000000}|{2,10: 0.00}|{3,-10:0.000}|",aHex, aBin, b, c);
    }
}

