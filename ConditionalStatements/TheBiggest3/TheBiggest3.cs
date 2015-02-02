//The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.
//Examples:

//a	        b	    c	    biggest
//5	        2	    2   	5
//-2	    -2	    1	    1
//-2	    4	    3	    4
//0	        -2.5	5	    5
//-0.1	    -0.5	-1.1	-0.1

using System;
using System.Globalization;
using System.Threading;


class TheBiggest3
{
    static double IsNumber(string number)
    {
        bool test = true;
        double result;
        do
        {
            test = double.TryParse(number, out result);
            if (test == false)
            {
                Console.Write("Not Legid! Enter again: ");
                number = Console.ReadLine();
            }
        } while (test != true);

        return result;
    }

    static double ToLegitNumber(string number)
    {
        string newString = number.Replace(',', '.');
        return IsNumber(newString);
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double maxNum= double.MinValue;
        double num;

        for (int i = 1; i <= 3; i++)
			{
			Console.Write("Enter real number: ");
            num = ToLegitNumber(Console.ReadLine());
			if (num > maxNum)
	            {
		            maxNum = num;
	            }
            }

        Console.WriteLine(maxNum);

    }
}
