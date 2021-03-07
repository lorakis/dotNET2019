using System;
using System.Collections.Generic;
using System.Linq;


namespace _1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            System.IO.StreamReader plik = new System.IO.StreamReader("plik.txt");
            string l;
            while ((l = plik.ReadLine()) != null)
            {
                list.Add(Convert.ToInt32(l));
            }
            var q = from liczba in list
                        where liczba > 100
                        orderby liczba descending
                        select liczba;

            Console.WriteLine("q:");
            foreach (var element in q)
                Console.Write(element + " ");
            
            Console.WriteLine();
            Console.WriteLine("q2:");
            var q2 = list.Where(x => x > 100).OrderByDescending(x => x);
            foreach (var element in q2)
                Console.Write(element + " ");

        }
    }
}
