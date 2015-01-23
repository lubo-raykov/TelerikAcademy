/*
 * Rectangles

    Write an expression that calculates rectangle’s perimeter and area by given width and height.
    Examples:

    width	height	perimeter	area
    3	    4	    14	        12
    2.5	    3	    11	        7.5
    5	    5	    20	        25
 */

using System;

class RectanglePerimeterArea
{
    static void Main()
    {
        Console.WriteLine("Enter the width:");
        string input = Console.ReadLine();                  //NOTE: according to system settings of every computer 
        double rectangleWidth = Convert.ToDouble(input);    //      floating point format can be entered with '.' or ',' the odd will crash 
        Console.WriteLine("Enter the hight:");
        input = Console.ReadLine();
        double rectangleHeight = Convert.ToDouble(input);
       
        double rectanglePerimeter = 2 * (rectangleWidth + rectangleHeight);
        double rectangeleArea = rectangleHeight * rectangleWidth;
        
        Console.WriteLine("the perimeter of the Rectangle is {0} and it's area is {1}.", rectanglePerimeter, rectangeleArea);
    }
}

