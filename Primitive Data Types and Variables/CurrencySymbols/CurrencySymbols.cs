using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencySymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //EUR € 8364
            c = (char)8364;
            Console.WriteLine("EUR " + c);
            //GBP £ 163
            c = (char)163;
            Console.WriteLine("GPB " + c);
            //USD $ 36
            c = (char)36;
            Console.WriteLine("USD " + c);
            //JPY ¥ 165
            c = (char)165;
            Console.WriteLine("JPY " + c);
        }
    }
}
