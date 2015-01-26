//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
//Examples:

//r	perimeter	area
//2	12.57	12.57
//3.5	21.99	38.48

using System;
using System.Threading;
using System.Globalization;


class CirclePerimeterArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter Cirle\'s radius: ");
        string radius = Console.ReadLine();
        
        radius = radius.Replace(',', '.');
        double radiusDouble;
        bool isNumber = double.TryParse(radius, out radiusDouble);
        if (isNumber == false)
        {
            Console.WriteLine("This is not a legit number!");
            return;
        }
        
        double perimeter = 2 * Math.PI * radiusDouble;
        double area = Math.PI * Math.Pow(radiusDouble, 2);

        Console.WriteLine("Cirle\'s perimenter is {0:0.00} and the area is {1:0.00}", perimeter, area);
    }
}

