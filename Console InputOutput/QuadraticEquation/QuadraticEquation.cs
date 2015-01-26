//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Examples:

//a	b	c	roots
//2	5	-3	x1=-3; x2=0.5
//-1	3	0	x1=3; x2=0
//-0.5	4	-8	x1=x2=4
//5	2	8	no real roots

using System;
using System.Threading;
using System.Globalization;

class QuadraticEquation
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

        string myNumber;
        
        Console.Write("Enter A value: ");
        myNumber = Console.ReadLine();
        double a = ToLegitNumber(myNumber);

        Console.Write("Enter B value: ");
        myNumber = Console.ReadLine();
        double b = ToLegitNumber(myNumber);

        Console.Write("Enter C value: ");
        myNumber = Console.ReadLine();
        double c = ToLegitNumber(myNumber);

        //Console.WriteLine(a + " " + b + " " + c);
        double root1;
        double root2;
        
        if (a == 0)
        {
            root1 = -1 * (c / b);
            Console.WriteLine("x1=x2={0}", root1);
        }

        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            if (discriminant == 0)
            {
                root2 = (-1 * b) / (2 * a);
                Console.WriteLine("x1=x2={0}", root2);
            }
            else
            {
                root1 = (-1 * b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                root2 = (-1 * b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine("x1={0}; x2={1}", root1, root2);
            }
        }
    }
}

