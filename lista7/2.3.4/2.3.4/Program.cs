using System;
using System.Threading;

namespace _2._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();
            const int liczba_krzesel = 2;
            Semaphore poczekalnia = new Semaphore(liczba_krzesel, liczba_krzesel);
            Semaphore krzeslo = new Semaphore(1, 1);
            Semaphore krzeslo_golibrody = new Semaphore(0, 1);
            Semaphore blokada = new Semaphore(0, 1);
            bool koniec = false;
            void Golibroda()
            {
                while (!koniec)
                {
                    Console.WriteLine("Golibroda śpi.");
                    krzeslo_golibrody.WaitOne();
                    if (!koniec)
                    {
                        Console.WriteLine("Golibroda obcina.");
                        Thread.Sleep(300);
                        Console.WriteLine("Golibroda skończył obcinać.");
                        blokada.Release();
                    }
                    else
                    {
                        Console.WriteLine("Golibroda  śpi.");
                    }
                }
                return;
            }
            void Klient(Object number)
            {
                int Number = (int)number;
                Console.WriteLine("Klient {0} idzie do golibrody.", Number);
                Thread.Sleep(Rand.Next(1, 5) * 1000);
                Console.WriteLine("Klient {0} przyszedł!", Number);
                poczekalnia.WaitOne();
                Console.WriteLine("Klient {0} wchodzi do poczekani.", Number);
                krzeslo.WaitOne();
                poczekalnia.Release();
                Console.WriteLine("Klient {0} budzi golibrodę.", Number);
                krzeslo_golibrody.Release();
                blokada.WaitOne();
                krzeslo.Release();
                Console.WriteLine("Klient {0} wychodzi.", Number);
            }
            Thread GolibrodaThread = new Thread(Golibroda);
            GolibrodaThread.Start();
            Thread[] Klienci = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                Klienci[i] = new Thread(new ParameterizedThreadStart(Klient));
                Klienci[i].Start(i);
            }
            for (int i = 0; i < 5; i++)
            {
                Klienci[i].Join();
            }
            koniec = true;
            krzeslo_golibrody.Release();

            GolibrodaThread.Join();
            Console.WriteLine("Koniec pracy!");
        }
    }
}
