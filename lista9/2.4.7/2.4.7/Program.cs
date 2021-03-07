using System;
using System.Xml.Linq;
using System.Linq;
using System.Text;

namespace _2._4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            char pierwszaLitera = Console.ReadLine()[0];
                       
            string wypisz = "";
            XDocument xdoc = XDocument.Load("dane.xml");

            var studenci = from s in xdoc.Descendants("{studenci}Osoba")
                           select s;

            Console.WriteLine();

            foreach (var st in studenci)
            {
                char drugaDuza = ' ';
                int i = 0;
                while (drugaDuza.Equals(' '))
                {
                    i++;
                    if (Char.IsUpper(st.Value, i))
                        drugaDuza = st.Value[i];
                }
                if (drugaDuza == Char.ToLower(pierwszaLitera) || drugaDuza == Char.ToUpper(pierwszaLitera))
                    wypisz += st.Value + " ";
            }

            Console.WriteLine(wypisz);

        }
    }
}
