using System;



class NullValues
{
    /*
     *  Create a program that assigns null values to an integer and to a double variable.
        Try to print these variables at the console.
        Try to add some number or the null literal to these variables and print the result.
     */

    static void Main()
    {
        int? intVar = null;
        double? doubleVar = null;
        Console.WriteLine("The value of intVar is " + intVar);
        Console.WriteLine("The value of doubleVar is " +  doubleVar);
        intVar = 5;
        doubleVar = '\0';
        doubleVar += 3.3;
        Console.WriteLine("The new value of intVar is " + intVar);
        Console.WriteLine("The new value of doubleVar is " + doubleVar);

    }
}

