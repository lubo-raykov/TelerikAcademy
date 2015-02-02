//Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
//Examples:
//n	randomized numbers 1…n
//3	2 1 3
//10	3 4 8 2 6 7 9 1 10 5
//The above output is just an example. Due to randomness, your program most probably will produce other result

using System;


class RandomizeTheSequence
{
    static void FillArrayInt(int[] arr, int filler)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = filler;
        }
    }

    static void WriteArray(int[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            Console.Write(arr[i]);
            if (i!= length)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Random rand = new Random();
        int temp;
        bool flag = false;

        int[] randSecuence = new int[n];
        FillArrayInt(randSecuence, -1);
        
        int[] isUsed = new int[n+1];             //array of flags,lamps,semafors
        FillArrayInt(isUsed, 0);

        for (int i = 1; i <= n; i++)            //in ordered sequence for each elemnt of randSequence 
        {
            while (flag == false)
            {
                temp = rand.Next(1, n+1);       //generates one random in the range 
                
                if (isUsed[temp] == 0)          //is used holds with 1 numbers that have already been taken, 0 - not taken yet
                {                               //so it keeps giving random numbers until one that is not yet taken comes
                    randSecuence[i-1] = temp;   //when it comes it is assigned to the current sequence member
                    isUsed[temp] = 1;           //the numaber is marked as taken
                    flag = true;                //confirmation for succesful asignment for the while  
                }
                else
                {
                    flag = false;
                }
            }
            flag = false;                       // already a number has been asigned and tha loop continues to nex member 
        }
        
        WriteArray(randSecuence);
        //WriteArray(isUsed);

 }
}

