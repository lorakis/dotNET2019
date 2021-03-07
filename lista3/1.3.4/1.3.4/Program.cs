using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Podaj lokalizację folderu, np C:\Users\Administrator\Desktop\AdZad4:");
            string s = Console.ReadLine();

            System.IO.DirectoryInfo folder = new System.IO.DirectoryInfo(s);
            IEnumerable<System.IO.FileInfo> listaPlikow = folder.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            var rozmiar = from plik in listaPlikow
                       let len = plik.Length
                       select len;
            var suma = rozmiar.Aggregate((sum, size) => sum + size);
            Console.WriteLine(suma + " bytes");
        }
    }
}
