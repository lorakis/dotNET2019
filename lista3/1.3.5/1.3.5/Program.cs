using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> osoba = new List<string>();
            List<string> konto = new List<string>();
            System.IO.StreamReader wczyt_ososba = new System.IO.StreamReader("osoba.txt");
            System.IO.StreamReader wczyt_konto = new System.IO.StreamReader("konto.txt");
            string line;
            while ((line = wczyt_ososba.ReadLine()) != null)
                osoba.Add(line);

            while ((line = wczyt_konto.ReadLine()) != null)
                konto.Add(line);

            var q = from o in osoba
                    join k in konto
                    on o.Split(" ").ElementAt(2) equals k.Split(" ").ElementAt(0)
                    select o + " " + k.Split(" ").ElementAt(1);

            foreach (var i in q)
                Console.WriteLine(i);
        }
    }
}
