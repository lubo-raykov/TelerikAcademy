//Beer Time

//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
//Examples:

//time	result
//1:00 PM	beer time
//4:30 PM	beer time
//10:57 PM	beer time
//8:30 AM	non-beer time
//02:59 AM	beer time
//03:00 AM	non-beer time
//03:26 AM	non-beer time

using System;
using System.Globalization;
using System.Threading;


class BeerTime
{
    static void Main()
    {
        //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        Console.WriteLine("Enter a time in format \"hh:mm tt\"");
        string timeText = Console.ReadLine();
        string timeStart = "01:00 PM";
        string timeEnd = "03:00 AM";
        string timeEndDay = "11:59 PM";
        string timeEndStart = "00:00 AM";
        

        DateTime myTime = Convert.ToDateTime(timeText);
        DateTime startTime = Convert.ToDateTime(timeStart);
        DateTime endTime = Convert.ToDateTime(timeEnd);
        DateTime endDayTime = Convert.ToDateTime(timeEndDay);
        DateTime stratDayTime = Convert.ToDateTime(timeEndStart);

        if ((myTime >= stratDayTime && myTime < endTime) || (myTime >= startTime && myTime <= endDayTime))
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }

    }
}

