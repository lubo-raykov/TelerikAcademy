using System;

class QuotesInString
{
    /*
     * Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
    Do the above in two different ways - with and without using quoted strings.
    Print the variables to ensure that their value was correctly defined.
     */


    static void Main()
    {
        string test1 = "The \"use\" of quotations causes difficulties.";
        string test2 = "The use of quotations causes difficulties.";
        Console.WriteLine(test1);
        Console.WriteLine(test2);
    }
}

