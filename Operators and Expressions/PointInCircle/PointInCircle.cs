/*
 * Point in a Circle

    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
    Examples:

    x	y	    inside
    0	1	    true
    -2	0	    true
    -1	2	    false
    1.5	-1	    true
   -1.5 -1.5	false
    100	-30	    false
    0	0	    true
    0.2	-0.8	true
    0.9	-1.93	false
    1	1.655	true
 */

using System;


class PointInCircle
{
    
    
          static void Main()
    {
        double cirlceRadius = 2.0d;
        Console.WriteLine("Enter point's X");
        string input = Console.ReadLine();
        double pointX = Convert.ToDouble(input);
        Console.WriteLine("Enter point's Y");
        input = Console.ReadLine();
        double pointY = Convert.ToDouble(input);
        double pointToCenter = Math.Sqrt(pointX * pointX + pointY * pointY);

        bool isInside = cirlceRadius >= pointToCenter;
        Console.WriteLine("The point is inside: " + isInside);

    }
}

