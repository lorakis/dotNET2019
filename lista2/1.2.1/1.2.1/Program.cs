using System;
using System.Collections;
using System.Collections.Generic;

namespace _1._2._1
{

    class Porownanie
    {
        private TimeSpan Czas;
        private DateTime Start, Stop;
        private int ile = 100000;
        private int rob;
        public void Hashatable()
        {
            Random rng = new Random();
            Start = DateTime.Now;
            Hashtable hash = new Hashtable();
            for (int i = 0; i < ile; i++)
            {
                hash.Add(i, rng.Next(0, 10000));
            }
            for (int i = 0; i < ile; i++)
            {
                rob = (int)hash[i];
            }
            for (int i = 0; i < ile; i++)
            {
                hash.Remove(i);
            }
            Stop = DateTime.Now;
            Czas = Stop - Start;
            Console.WriteLine("Hashtable: " + Czas);
        }
        public void Dictionary()
        {
            Random rng = new Random();
            Start = DateTime.Now;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < ile; i++)
            {
                dict.Add(i, rng.Next(0, 10000));
            }
            for(int i = 0; i < ile; i++)
            {
                rob = dict[i];
            }
            for(int i = 0; i < ile; i++)
            {
                dict.Remove(i);
            }
            Stop = DateTime.Now;
            Czas = Stop - Start;
            Console.WriteLine("Slownik: " + Czas);
        }
        public void List()
        {
            Random rng = new Random();
            Start = DateTime.Now;
            List<int> list = new List<int>();
            for (int i = 0; i < ile; i++)
            {
                list.Add(rng.Next(0, 10000));
            }
            foreach (int i in list)
            {
                rob = i;
            }
            for (int i = 0; i < ile; i++)
            {
                list.Remove(i);
            }
            Stop = DateTime.Now;
            Czas = Stop - Start;
            Console.WriteLine("Lista: " + Czas);
        }
        public void ArrayList()
        {
            Random rng = new Random();
            Start = DateTime.Now;
            ArrayList alist = new ArrayList();
            for (int i = 0; i < ile; i++)
            {
                alist.Add(rng.Next(0, 10000));
            }
            foreach (int i in alist)
            {
                rob = i;
            }
            for (int i = 0; i < ile; i++)
            {
                alist.Remove(i);
            }
            Stop = DateTime.Now;
            Czas = Stop - Start;
            Console.WriteLine("ArrayLista: " + Czas);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Porownanie por = new Porownanie();
            por.Dictionary();
            por.Hashatable();

            por.List();
            por.ArrayList();
        }
    }
}
