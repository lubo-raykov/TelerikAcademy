using System;

class ObjectString
{
    /*
     * Declare two string variables and assign them with Hello and World.
 Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
 Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
     */

    static void Main()
    {
        string word1 = "Hello";
        string word2 = "World";
        object combined = word1 + ' ' + word2;
        string combined1 = (string)combined;
        Console.WriteLine(combined1);
    }
}

