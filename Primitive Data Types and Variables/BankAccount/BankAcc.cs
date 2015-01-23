using System;



class BankAccount
{
    /*
     * A bank account has a holder name (first name, middle name and last name), 
       available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
        Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
     */

    static void Main()
    {
        string firstName;
        string middleName;
        string lastName;
        decimal balance;    //number with floating point for high-precision calculation
        string bankName;
        string iban;        //combines letters and numbers
        string cardNum1;    //16 digid non-calculative 
        string cardNum2;
        string cardNum3;

        //----------------------------------------inputting data------------------------------------
        Console.WriteLine("Enter first name:");
        firstName = Console.ReadLine();

        Console.WriteLine("Enter middle name:");
        middleName = Console.ReadLine();

        Console.WriteLine("Enter last name:");
        lastName = Console.ReadLine();

        Console.WriteLine("Enter balance:"); //depends on the settings of the computer if 5.24545 crashes try 5,24545 or viseversa
        string input = Console.ReadLine();
        System.Text.StringBuilder sb = new System.Text.StringBuilder(input); //StringBuilder is used to opereate fast&safe inside the string
        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] == '.')       //if it crash repace these 2 chars
            {
                sb[i] = ',';        //if it crash repace these 2 chars
            }
        }
        input = sb.ToString();      //tyried to converet sb to decimal directly - didn't work
        balance = Convert.ToDecimal(input);

        Console.WriteLine("Enter bank name:");
        bankName = Console.ReadLine();

        Console.WriteLine("Enter IBAN (format AB12 ABCD 1234 5678 9012 34):");
        iban = Console.ReadLine();

        Console.WriteLine("Enter card number 1 (format 16 digits):");
        cardNum1 = Console.ReadLine();

        Console.WriteLine("Enter card number 2 (format 16 digits):");
        cardNum2 = Console.ReadLine();

        Console.WriteLine("Enter card number 3 (format 16 digits):");
        cardNum3 = Console.ReadLine();

        //----------------------------------------outputting data------------------------------------
        Console.WriteLine("--------- BANK ACCOUNT ---------");
        Console.WriteLine("  First name: {0}", firstName);
        Console.WriteLine(" Middle name: {0}", middleName);
        Console.WriteLine("   Last name: {0}", lastName);
        Console.WriteLine("     Balance: {0}", balance.ToString("F"));  //ToString("F") rounds & ensures 2 decimal places 54.5 -> 54.50
        Console.WriteLine("   Bank Name: {0}", bankName);
        Console.WriteLine("        IBAN: {0}", iban);
        string space = new string(' ', 11);
        Console.WriteLine("Card numbers:\n{3}1. {0}\n{3}2. {1}\n{3}3. {2}", cardNum1, cardNum2, cardNum3, space);

    }
}

