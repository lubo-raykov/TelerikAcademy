//Check for a Play Card

//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
//character	Valid card sign?
//5	yes
//1	no
//Q	yes
//q	no
//P	no
//10	yes
//500	no


using System;
using System.Collections.Generic;

class CheckPlayCard
{
    static void Main()
    {
        Console.Write("Enter card sign to check: ");
        string card= Console.ReadLine();
        //creating list holdig allowed card signs
        List<string> cardSigns = new List<string>();
        cardSigns.Add("2");
        cardSigns.Add("3");
        cardSigns.Add("4");
        cardSigns.Add("5");
        cardSigns.Add("6");
        cardSigns.Add("7");
        cardSigns.Add("8");
        cardSigns.Add("9");
        cardSigns.Add("10");
        cardSigns.Add("J");
        cardSigns.Add("D");
        cardSigns.Add("K");
        cardSigns.Add("A");

        if (cardSigns.Contains(card))
        {
            Console.WriteLine("yes");
            return;
        }
        Console.WriteLine("no");

    }
}

