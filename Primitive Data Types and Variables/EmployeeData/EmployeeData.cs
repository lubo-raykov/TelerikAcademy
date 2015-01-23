using System;


    class Program
    {
        /*
         *  A marketing company wants to keep record of its employees. Each record would have the following characteristics:
            First name
            Last name
            Age (0...100)
            Gender (m or f)
            Personal ID number (e.g. 8306112507)
            Unique employee number (27560000…27569999)
            Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
         */
        
        static void Main()
        {
            string firstName;
            string lastName;
            byte age;
            char gender;
            string idNumber;
            int employeeNum;

            //----------------------------------------inputting data------------------------------------
            Console.WriteLine("Enter first name:");
            firstName = Console.ReadLine();
            
            Console.WriteLine("Enter last name:");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter age:");
            string input = Console.ReadLine();
            age = Convert.ToByte(input);

            Console.WriteLine("Enter gender f/m:");
            input = Console.ReadLine();
            gender = Convert.ToChar(input);
            
            Console.WriteLine("Enter ID number (10 digits):");
            idNumber = Console.ReadLine();

            Console.WriteLine("Enter employee number (from 27560000 to 27569999):");
            input = Console.ReadLine();
            employeeNum = Convert.ToInt32(input);

            //----------------------------------------outputting data------------------------------------
            Console.WriteLine("----- EMPLOYEE DATA -----");
            Console.WriteLine("     First name: {0}", firstName);
            Console.WriteLine("      Last name: {0}", lastName);
            Console.WriteLine("            Age: {0}", age);
            Console.WriteLine("        Geneder: {0}", gender);
            Console.WriteLine("      ID number: {0}", idNumber);
            Console.WriteLine("Employee number: {0}", employeeNum);
           
        }
    }

