using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            System.IO.StreamReader plik = new System.IO.StreamReader("plik.txt");
            string l;
            while ((l = plik.ReadLine()) != null)
            {
                list.Add(l);
            }

            var q = list.GroupBy(x => x[0].ToString()).OrderBy(x => x.Key);

            Console.WriteLine("q:");
            foreach (var i in q)
                Console.Write(i.Key + " ");

        }
    }
}
