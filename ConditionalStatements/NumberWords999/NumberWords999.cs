//Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;


class NumberWords999
{
    static string AddStr_0_19(int number)
    {
        string addOn="";
        switch (number)
        {
            case 0: addOn = "zero";
                    return addOn;
            case 1: addOn = "one";
                    return addOn;    
            case 2: addOn = "two";
                    return addOn;
            case 3: addOn = "three";
                    return addOn;
            case 4: addOn = "four";
                    return addOn;
            case 5: addOn = "five";
                    return addOn;
            case 6: addOn = "six";
                    return addOn;
            case 7: addOn = "seven";
                    return addOn;
            case 8: addOn = "eight";
                    return addOn;
            case 9: addOn = "nine";
                    return addOn;
            case 10: addOn = "ten";
                    return addOn;
            case 11: addOn = "eleven";
                    return addOn;
            case 12: addOn = "twelve";
                    return addOn;
            case 13: addOn = "thirteen";
                    return addOn;
            case 14: addOn = "fourteen";
                    return addOn;
            case 15: addOn = "fifteen";
                    return addOn;
            case 16: addOn = "sixteen";
                    return addOn;
            case 17: addOn = "seventeen";
                    return addOn;
            case 18: addOn = "eighteen";
                    return addOn;
            case 19: addOn = "nineteen";
                    return addOn;
            default: addOn = "ERROR";
                    return addOn;
        }
    }

    static string AddOn_20_99(int number)
    {
        string addOn;
        if (number<20)
        {
            addOn = AddStr_0_19(number);
            return addOn;
        }
        else
        {
            int unit = number % 10;
            int dec = number % 100 /10;

            switch (dec)
            {
                case 2: addOn = "twenty";
                        if (unit != 0)
                        {
                            addOn= addOn + " " + AddStr_0_19(unit);
                        }
                        return addOn;
                case 3: addOn = "thirty";
                        if (unit != 0)
                        {
                            addOn = addOn + " " + AddStr_0_19(unit);
                        }
                        return addOn;
                case 4: addOn = "forty";
                        if (unit != 0)
                        {
                            addOn = addOn + " " + AddStr_0_19(unit);
                        }
                        return addOn;
                case 5: addOn = "fifty";
                        if (unit != 0)
                        {
                            addOn = addOn + " " + AddStr_0_19(unit);
                        }
                        return addOn;
                case 6: addOn = "sixty";
                        if (unit != 0)
                        {
                            addOn = addOn + " " + AddStr_0_19(unit);
                        }
                        return addOn;
                case 7: addOn = "seventy";
                        if (unit != 0)
                        {
                            addOn = addOn + " " + AddStr_0_19(unit);
                        }
                        return addOn;
                case 8: addOn = "eighty";
                        if (unit != 0)
                        {
                            addOn = addOn + " " + AddStr_0_19(unit);
                        }
                        return addOn;
                case 9: addOn = "ninety";
                        if (unit != 0)
                        {
                            addOn = addOn + " " + AddStr_0_19(unit);
                        }
                        return addOn;
                default:
                    addOn = "ERROR";
                    return addOn;
            }
        }
    }

    static string AddOn_100_999(int number)
    {
        string addOn;
        if (number < 100)
        {
            addOn = AddOn_20_99(number);
            return addOn;
        }
        else
        {
            int hundrets = number % 1000 / 100;
            int dec = number % 100;

            if (dec != 0)
            {
                addOn = AddStr_0_19(hundrets) + " hundred and " + AddOn_20_99(dec);
                return addOn;
            }
            else
            {
                addOn = AddStr_0_19(hundrets) + " hundred";
                return addOn;
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        string result = AddOn_100_999(number);
        Console.WriteLine(result);
    }
}
