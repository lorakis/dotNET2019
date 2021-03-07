using System;
using System.Collections.Generic;

namespace _2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            NonGenericNoDuplicate nonGenericNoDuplicate = new NonGenericNoDuplicate("test1");
            nonGenericNoDuplicate.Add("test2");
            nonGenericNoDuplicate.Add(3);
            nonGenericNoDuplicate.Add(true);
            Console.WriteLine(nonGenericNoDuplicate.ToString());
            nonGenericNoDuplicate.Add("test1");
            nonGenericNoDuplicate.Add(3);
            Console.WriteLine(nonGenericNoDuplicate.ToString());
            nonGenericNoDuplicate.clear();
            Console.WriteLine(nonGenericNoDuplicate.ToString());
            nonGenericNoDuplicate.Add("test10");
            Console.WriteLine(nonGenericNoDuplicate.ToString());
        }
    }
    class NonGenericNoDuplicate
    {
        private List<object> array;

        public NonGenericNoDuplicate()
        {
            array = new List<object>();
        }

        public NonGenericNoDuplicate(object t)
        {
            array = new List<object>();
            array.Add(t);
        }

        public void clear()
        {
            array.Clear();
        }

        public string checkType(int numer)
        {
            return array[numer].GetType().ToString();
        }

        public object checkCont(int numer)
        {
            return array[numer];
        }

        public void Add(Object cont)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i].Equals(cont))
                {
                    Console.WriteLine("Same object already exists.");
                    return;
                }
            }
            array.Add(cont);
        }
        public override string ToString()
        {
            if (array.Count == 0)
                return "List is empty.";
            else
            {
                string rob = "";
                foreach (object i in array)
                {
                    rob += i + ", ";
                }
                return rob;
            }
        }
    }
}
