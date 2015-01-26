//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

//Example input:

//Company name:	Telerik Academy
//Company address:	31 Al. Malinov, Sofia
//Phone number:	+359 888 55 55 555
//Fax number:	2
//Web site:	http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	25
//Manager phone:	+359 2 981 981

//Example output:

//Telerik Academy
//Address: 231 Al. Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        //--------------------------input----------------------------
        //  Company name
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        if (companyName == "")
	    {
		    companyName = "(no name)";
	    }
        //  Company address
        Console.Write("Enter company\'s address: ");
        string companyAddress = Console.ReadLine();
        if (companyAddress == "")
	    {
		    companyAddress = "(no address)";
	    }
        //  Company phone
        char literal;
        bool validPhone = true;
        Console.Write("Enter phone number: ");
        string companyPhone = Console.ReadLine();
        for (int i = 0; i < companyPhone.Length; i++)
        {
            literal = companyPhone[i];
            if ((literal >= 'a' && literal <= 'z') || (literal >= 'A' && literal <= 'Z'))
            {
                validPhone = false;
            }
        }
        if (companyPhone.Length < 8 || validPhone == false)
        {
            companyPhone = "(no phone)";
        }
        //  Company fax
        Console.Write("Enter fax number: ");
        string companyFax = Console.ReadLine();
        validPhone = true;
        for (int i = 0; i < companyFax.Length; i++)
        {
            literal = companyFax[i];
            if ((literal >= 'a' && literal <= 'z') || (literal >= 'A' && literal <= 'Z'))
            {
                validPhone = false;
            }
        }
        if (companyFax.Length < 8 || validPhone == false)
        {
            companyFax = "(no fax)";
        }
        //  Company web site
        Console.Write("Enter web site: ");
        string companyWebSite = Console.ReadLine();
        if (companyWebSite.Length < 4)
        {
            companyWebSite = "(no web site)";
        }
        //  Manager name
        Console.Write("Enter manager\'s first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager\'s last name: ");
        string managerLastName = Console.ReadLine();
        string managerName = managerFirstName + " " + managerLastName;
        if (managerName.Length < 2 || managerLastName == "")
        {
            managerName = "(no entry)";
        }
        //  Manager age
        Console.Write("Enter manager\'s age: ");
        string managerAge = Console.ReadLine();
        bool validAge = true;
        if (managerAge[0] == '0')
        {
            validAge = false;
        }
        else
        {
            for (int i = 0; i < managerAge.Length; i++)
            {
                literal = managerAge[i];
                if (literal < '0' || literal > '9')
                {
                    validAge = false;
                }
            }
        }
        if (validAge == false)
        {
            managerAge = "(unknown)";
        }
        //  Manager phone
        Console.Write("Enter manager\'s phone number: ");
        string managerPhone = Console.ReadLine();
        validPhone = true;
        for (int i = 0; i < managerPhone.Length; i++)
        {
            literal = managerPhone[i];
            if ((literal >= 'a' && literal <= 'z') || (literal >= 'A' && literal <= 'Z'))
            {
                validPhone = false;
            }
        }
        if (managerPhone.Length < 8 || validPhone == false)
        {
            managerPhone = "(no phone)";
        }
        
        //--------------------------output----------------------------
        Console.WriteLine("\n{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} (age: {6}, tel. {7})", companyName, companyAddress, companyPhone, companyFax, companyWebSite, managerName, managerAge, managerPhone);

    }
}

