//Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
//output

//2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//…  
//K of spades, K of clubs, K of hearts, K of diamonds
//A of spades, A of clubs, A of hearts, A of diamonds
//Note: You may use the suit symbols instead of text.


using System;


class WholeSuitCards
{
    static void Main()
    {
        string card = "";
        char symbol = '@'; 
        
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                
                switch (i)
                {
                    case 2: card = "2";
                        break;
                    case 3: card = "3";
                        break;
                    case 4: card = "4";
                        break;
                    case 5: card = "5";
                        break;
                    case 6: card = "6";
                        break;
                    case 7: card = "7";
                        break;
                    case 8: card = "8";
                        break;
                    case 9: card = "9";
                        break;
                    case 10: card = "10";
                        break;
                    case 11: card = "J";
                        break;
                    case 12: card = "D";
                        break;
                    case 13: card = "K";
                        break;
                    case 14: card = "A";
                        break;
                }

                switch (j)
                {
                    case 1: symbol = (char)5;
                        break;
                    case 2: symbol = (char)6;
                        break;
                    case 3: symbol = (char)3;
                        break;
                    case 4: symbol = (char)4;
                        break;
                }
                
                Console.Write("{0} of {1}", card ,symbol);
                if (j != 4)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();    
                }
            }
        }
    }
}

