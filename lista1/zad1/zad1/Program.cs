using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100000; i++)
            {
                bool n = true;
                int j = i;
                int k = i;
                int w = 0;
                while (k != 0)
                {
                    k = k / 10;
                    int a = j - k * 10;
                    j = j / 10;
                    if (a == 0 || i % a != 0)
                    {
                        n = false;
                        break;
                    }
                    w = w + a;
                }
                if (n == true && i % w == 0)
                    Console.WriteLine(i);

            }
        }
    }
}
