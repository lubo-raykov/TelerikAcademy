/*
 * Point Inside a Circle & Outside of a Rectangle

    Write an expression that checks for given point (x, y) if it is 
    within the circle K({1, 1}, 1.5) and 
    out of the rectangle R(top=1, left=-1, width=6, height=2).
    Examples:

    x	    y	    inside K & outside of R
    1	    2	    yes
    2.5	    2	    no
    0	    1	    no
    2.5	    1	    no
    2	    0	    no
    4	    0	    no
    2.5	    1.5	    no
    2	    1.5	    yes
    1	    2.5	    yes
    -100    -100	no
     */

using System;


class InsideOutside
{
    public struct Point
    {
        public double x;
        public double y;
        //Constructor
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public struct Rectangle
    {
       public double left;     //indicates most left side coordinates
       public double top;       //indicates most top side coordinates
       public double width;
       public double height;
       
        //Constructor
        public Rectangle(double top, double left, double width, double height)
        {
            this.top = top;
            this.left = left;
            this.width = width;
            this.height = height;            
        }
        
        public bool IsOutside(Point a)
        {
            if (a.y<=this.top && a.y>=(this.top-this.height) && a.x>=this.left && a.x<= (this.left+this.width))
            {
                return false;  
            }
            else
            {
                return true;
            }
        }
    }
    
    public struct Circle
    {
        public double radius;
        public Point center;
        //Constructor
        public Circle(double xCenter, double yCenter, double radius) 
        {
            this.radius = radius;
            this.center = new Point(xCenter, yCenter);
        }
        
        public bool IsInside(Point A)
        {
            double side1 = Math.Abs(A.x - center.x);
            double side2 = Math.Abs(A.y - center.y);
            double distance = Math.Sqrt(side1 * side1 + side2 * side2);
            if (distance <= this.radius)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
        
    static void Main()
    {
        //NOTE: according to system settings of every computer
        //      floating point format can be entered with '.' or ',' the odd will crash 
        
        Rectangle myRectangle = new Rectangle(1, -1, 6, 2);         //creating rectangle
        Circle myCircle = new Circle(1, 1, 1.5);                    //creating circle
        
        Console.WriteLine("Enter X coordinate of the point:");
        string input = Console.ReadLine();
        double myX = Convert.ToDouble(input);
        Console.WriteLine("Enter Y coordinate of the point:");
        input = Console.ReadLine();
        double myY = Convert.ToDouble(input);                       
        Point myPoint = new Point(myX, myY);                        //creating point
        
        string result="no"; 
        if (myRectangle.IsOutside(myPoint) && myCircle.IsInside(myPoint))
	    {
		result = "yes";
	    }
        
        Console.WriteLine();
        Console.WriteLine("The point ({0} {1}) is outside the rectangle and inside the cirlce:\n{2}",myPoint.x , myPoint.y , result);
        Console.WriteLine();        
    }
}
