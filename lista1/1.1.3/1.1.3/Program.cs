using System;
using System.Reflection;

namespace _1._1._3
{
    class Example
    {
        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method!");
        }
        public void PublicMetod()
        {
            Console.WriteLine("This is a public method#");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan Czas;
            DateTime Start, Stop;

            Start = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                typeof(Example).GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new Example(), null);
            }
            Stop = DateTime.Now;
            Czas = Stop - Start;

            Start = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                Example ex = new Example();
                ex.PublicMetod();
            }
            Console.WriteLine("Czas dla metody prywatniej: " + Czas);

            Stop = DateTime.Now;
            Czas = Stop - Start;
            Console.WriteLine("Czas dla metody publicznej: " + Czas);
        }
    }
}