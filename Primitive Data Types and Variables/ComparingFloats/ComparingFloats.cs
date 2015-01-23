using System;

class ComparingFloats
{
    /*
     *  Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
        Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

        Examples:

        Number a	Number b	Equal (with precision eps=0.000001)	Explanation
        5.3	6.01	false	The difference of 0.71 is too big (> eps)
        5.00000001	5.00000003	true	The difference 0.00000002 < eps
        5.00000005	5.00000001	true	The difference 0.00000004 < eps
        -0.0000007	0.00000007	true	The difference 0.00000077 < eps
        -4.999999	-4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
        4.999999	4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
     */
    
    //global constant
    const double eps = 0.000001d;
    
    //function that does the comparison
    static bool AreEqual(double num1, double num2)  
    {
        bool isEqual = true;

        if (Math.Abs(num1 - num2) >= eps)
        {
            isEqual = false;
        }
        return isEqual;
    }

    static void Main()
    {
        
        Console.WriteLine("Be Careful!\nDepending of System settings\nfloating point input may be \'.\' or \',\'\nThe odd will crash!");
        Console.WriteLine();
        Console.WriteLine("Enter the first number");
        string input = Console.ReadLine();
        double num1 = Convert.ToDouble(input);
        Console.WriteLine("Enter the second number");
        input = Console.ReadLine();
        double num2 = Convert.ToDouble(input);

        bool result = AreEqual(num1, num2);
        Console.WriteLine(result);

        Console.WriteLine("Control tests...");

        result = AreEqual(5.3d, 6.01d);
        Console.WriteLine(result);

        result = AreEqual(5.00000001d, 5.00000003d);
        Console.WriteLine(result);

        result = AreEqual(5.00000005d, 5.00000001d);
        Console.WriteLine(result);

        result = AreEqual(-0.0000007d, 0.00000007d);
        Console.WriteLine(result);

        result = AreEqual(-4.999999d, -4.999998d);
        Console.WriteLine(result);

        result = AreEqual(4.999999d, 4.999998d);
        Console.WriteLine(result);
    }
}

