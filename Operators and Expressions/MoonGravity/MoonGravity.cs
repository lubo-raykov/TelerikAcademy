/*
 * Gravitation on the Moon

    The gravitational field of the Moon is approximately 17% of that on the Earth.
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
    Examples:

    weight	weight on the Moon
    86	14.62
    74.6	12.682
    53.7	9.129
 */

using System;

    class MoonGravity
    {
        static void Main()
        {
            Console.WriteLine("Enter the weight of a man on Earth:");
            string input = Console.ReadLine();  //NOTE: according to system settings of every computer floating point format can be entered with '.' or ',' the odd will crash 
            double earthWeight = Convert.ToDouble(input);
            double moonWeight = earthWeight * 0.17;
            Console.WriteLine("The weight of that man on moon is {0}", moonWeight);
        }
    }

