using System;
using System.Globalization;

namespace _2._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo ci = new CultureInfo("pl-PL");
            DateTimeFormatInfo dtfi = ci.DateTimeFormat;
            foreach (string name in dtfi.MonthNames)
            {
                Console.WriteLine("\"{0}\"", name);
            }
            foreach (string name in dtfi.AbbreviatedMonthNames)
            {
                Console.WriteLine("\"{0}\"", name);
            }
            foreach (string name in dtfi.DayNames)
            {
                Console.WriteLine("\"{0}\"", name);
            }
            DateTime myDate = DateTime.Now;
            string en = myDate.ToString("dddd, dd MMMM yyyy", new CultureInfo("en-GB"));
            string de = myDate.ToString("dddd, dd MMMM yyyy", new CultureInfo("de-DE"));
            string fr = myDate.ToString("dddd, dd MMMM yyyy", new CultureInfo("fr-FR"));
            string ru = myDate.ToString("dddd, dd MMMM yyyy", new CultureInfo("ru-RU"));
            string ar = myDate.ToString("dddd, dd MMMM yyyy", new CultureInfo("AR-TN"));
            string cz = myDate.ToString("dddd, dd MMMM yyyy", new CultureInfo("cs-CZ"));
            string pl = myDate.ToString("dddd, dd MMMM yyyy", new CultureInfo("pl-PL"));

            Console.WriteLine(en);
            Console.WriteLine(de);
            Console.WriteLine(fr);
            Console.WriteLine(ru);
            Console.WriteLine(ar);
            Console.WriteLine(cz);
            Console.WriteLine(pl);
        }
    }
}
