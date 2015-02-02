//Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
//Example 1:

//program	user
//Please choose a type:	
//1 --> int	
//2 --> double	3
//3 --> string	
//Please enter a string:	hello
//hello*	
//Example 2:

//program	user
//Please choose a type:	
//1 --> int	
//2 --> double	2
//3 --> string	
//Please enter a double:	1.5
//2.5

using System;
using System.Globalization;
using System.Threading;


class IntDoubleString
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

        System.Console.WriteLine("Please, choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.WriteLine("Please enter an integer:");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer+1);
                break;
            case 2: Console.WriteLine("Please enter a double:");
                double doubl = ToLegitNumber(Console.ReadLine());
                Console.WriteLine(doubl + 1);
                break;
            case 3: Console.WriteLine("Please enter a string:");
                string str = Console.ReadLine();
                Console.WriteLine(str + '*');
                break;
        }
    }
}

