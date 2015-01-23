using System;


class HelloCSharp
{
    static void Main()
    {
        /*
        Problem 4. Hello World

        Create, compile and run a “Hello C#” console application.
        Ensure you have named the application well (e.g. “”HelloCSharp”).
        You should submit the Visual Studio project holding the HelloCSharp class as part of your homework.
         */


        // playing with console settings
        Console.BackgroundColor = ConsoleColor.DarkBlue;    // background color
        Console.ForegroundColor = ConsoleColor.White;       // font color
        Console.WindowHeight = 4;
        Console.WindowWidth = 30;

        Console.WriteLine("Hello world!");

        // again playing with console :P
        Console.Beep(500, 100);
    }
}

