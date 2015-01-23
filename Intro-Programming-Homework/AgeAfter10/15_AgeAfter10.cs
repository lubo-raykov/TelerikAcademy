using System;


class AgeAfter10
{
    static void Main()
    {
        /*
         Problem 15.* Age after 10 Years

        Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
         */
        DateTime today = DateTime.Now;

        Console.WriteLine("Enter your birtday dd.mm.yyyy");        //format should be D>>M>>Y separators differ
        string line = Console.ReadLine();
        DateTime birthday = Convert.ToDateTime(line);

        int age = today.Year - birthday.Year;
        if (today.Month < birthday.Month || (today.Month == birthday.Month && today.Day < birthday.Day))
            age--;

        Console.WriteLine();
        Console.WriteLine("Now you are " + age + " years old.");
        Console.WriteLine();
        Console.WriteLine("After 10 years you will be " + (age + 10) + " years old.");

    }
}

