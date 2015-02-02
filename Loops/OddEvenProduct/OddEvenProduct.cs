//Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
//Examples:

//numbers	result
//2 1 1 6 3	yes
//product = 6	
//3 10 4 6 5 1	yes
//product = 60	
//4 3 2 5 2	no
//odd_product = 16	
//even_product = 15

using System;


    class OddEvenProduct
    {
        static void Main()
        {
            string mySequence = Console.ReadLine();
            string[] numArr = mySequence.Split(' ');

            int productOdd = 1;
            int productEven = 1;

            for (int i = 0; i < numArr.Length; i++)
            {
                if (i%2 == 0) //odd --> first is 1
                {
                    productOdd *= int.Parse(numArr[i]); 
                }
                else
                {
                    productEven *= int.Parse(numArr[i]);
                }
            }

            if (productOdd == productEven)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }

