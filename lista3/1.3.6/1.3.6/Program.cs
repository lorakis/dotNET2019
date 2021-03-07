using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            System.IO.StreamReader logi = new System.IO.StreamReader("log.txt");
            string l;
            while ((l = logi.ReadLine()) != null)
                list.Add(l);

            var q = (from y in (from x in (from z in list 
                                           select z.Split(" ").ElementAt(1))
                                group x by x.Split(" ").ElementAt(0) into gr
                                select new
                                {
                                    ip = gr.Key,
                                    sum = gr.Count(),
                                })
                     orderby y.sum descending
                     select y).Take(3);

            foreach(var i in q)
                Console.WriteLine(i.ip + " " + i.sum);
        }
    }
}
