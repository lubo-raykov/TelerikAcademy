//Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is less and equal to 0 or more than 9, the program prints “invalid score”.
//Examples:

//score	result
//2	    20
//4	    400
//9	    9000
//-1	invalid score
//10	invalid score

using System;



class BonusScore
{
    static void Main()
    {
        Console.Write("Enter number between 0 and 9: ");
        int score = int.Parse(Console.ReadLine());

        if (score <= 0 || score > 9)
        {
            Console.WriteLine("invalid score");
            return;
        }
        int bonus;
        if (score > 0 && score <= 3)
        {
            bonus = 10;
        }
        else
        {
            if (score >= 4 && score <= 6)
            {
                bonus = 100;
            }
            else
            {
                bonus = 1000;
            }
        }

        Console.WriteLine(score*bonus);
    }
}

