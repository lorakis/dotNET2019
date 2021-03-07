using System;

namespace _1._3._1
{
    static class MyExtension
    {
        public static bool IsPalindrome(this string s)
        {
            s = s.Replace(" ", String.Empty);
            s = s.ToLower();
            int dl = s.Length;
            for(int i = 0; i < dl / 2; i++)
            {
                if (s[i] != s[dl - i - 1])
                    return false;
            }
            return true;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Kobyła ma mały bok";
            bool IsPalindrome1 = s1.IsPalindrome();
            Console.WriteLine(IsPalindrome1);

            string s2 = "Ikar łapał raki";
            bool IsPalindrome2 = s2.IsPalindrome();
            Console.WriteLine(IsPalindrome2);

            string s3 = "raz dwa trzy";
            bool IsPalindrome3 = s3.IsPalindrome();
            Console.WriteLine(IsPalindrome3);
        }
    }
}
