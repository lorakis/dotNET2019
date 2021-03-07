using System;
using System.Collections;
using System.Collections.Generic;

namespace _1._4._1
{
    class Porownanie
    {

        public int Foo1(int x, int y)
        {
            int wynik = x;
            for (int i = 0; i < x; i++)
            {
                wynik = wynik * x % y;
                for (int j = 0; j < y; j++)
                {
                    wynik = wynik - x + y;
                }
            }
            return wynik;
        }

        public dynamic Foo2(dynamic x, dynamic y)
        {
            int wynik = x;
            for (int i = 0; i < x; i++)
            {
                wynik = wynik * x % y;
                for (int j = 0; j < y; j++)
                {
                    wynik = wynik - x + y;
                }
            }
            return wynik;
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            Porownanie por = new Porownanie();
            TimeSpan Czas;
            DateTime Start, Stop;
  
            Start = DateTime.Now;
            por.Foo1(10000, 9000);
            Stop = DateTime.Now;
            Czas = Stop - Start;
            Console.WriteLine("Int: " + Czas);

            Start = DateTime.Now;
            por.Foo2(10000, 9000);
            Stop = DateTime.Now;
            Czas = Stop - Start;
            Console.WriteLine("Dynamic: " + Czas);
        }
    }
}
