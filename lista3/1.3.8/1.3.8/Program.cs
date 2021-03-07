using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Func<int, int> f = null;
            foreach( var item in list.Select( f = i => (i <= 2)? 1 : f(i-1) + f(i-2)))
                Console.WriteLine(item);
        }
    }
}
