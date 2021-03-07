using System;
using System.Collections.Generic;

namespace _1._2._3
{
    class Program
    {
        private static bool parzysta(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }

        // ForEach
        private static void wypisz(List<int> l)
        {
            foreach (int i in l)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<int> l1 = new List<int>();
            for(int i = 0; i < 20; i++)
            {
                l1.Add(rng.Next(0, 200));
            }
            Console.WriteLine("Lista 1:");
            wypisz(l1);

            // ConvertAll
            List<int> l2 = l1.ConvertAll(x => 3 * x);
            Console.WriteLine("Lista 2:");
            wypisz(l2);

            // FindAll
            List<int> l3 = l2.FindAll(parzysta);
            Console.WriteLine("Lista 3:");
            wypisz(l3);

            // RemoveAll
            Console.WriteLine($"Usunieto {l1.RemoveAll(match: parzysta)} elementow z lListy 1");
            Console.WriteLine("Lista 1:");
            wypisz(l1);

            // Sort
            List<int> l4 = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                l4.Add(rng.Next(0, 200));
            }
            Console.WriteLine("Lista 4:");
            wypisz(l4);
            l4.Sort();
            Console.WriteLine("Lista 4 posortowana:");
            wypisz(l4);
        }
    }
}
