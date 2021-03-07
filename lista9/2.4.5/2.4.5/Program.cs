using System;
using System.Collections.Generic;
using System.Xml;

namespace _2._4._5
{
    class Program
    {
        public class Student
        {
            public string Imie;
            public string Nazwisko;
            public string Data;
            public string Adres_Staly;
            public string Adres_Tymczasowy;
            public Zajecia Zajecia;
            public Student(string i, string n, string d, string staly, string tymcz, Zajecia z)
            {
                Imie = i;
                Nazwisko = n;
                Data = d;
                Adres_Staly = staly;
                Adres_Tymczasowy = tymcz;
                Zajecia = z;
            }
            public override string ToString()
            {
                string res = "Imię: " + Imie
                    + "\nNazwiasko: " + Nazwisko
                    + "\nData urodzenia: " + Data
                    + "\nAdres stały: " + Adres_Staly
                    + "\nAdres tymczasowy: " + Adres_Tymczasowy
                    + "\nPrzedmioty i ocena: \n\t";

                foreach (var elem in Zajecia.PrzedmiotOcena)
                {
                    res += "" + elem.Key + " - " + elem.Value + "\n\t";
                }

                return res;
            }
        }
        public class Zajecia
        {
            public Zajecia() { PrzedmiotOcena = new Dictionary<string, string>(); }
            public Dictionary<string, string> PrzedmiotOcena;
        }
        static void Main(string[] args)
        {
            List<Student> studenci = new List<Student>();
            XmlDocument document = new XmlDocument();
            document.Load("dane.xml");

            foreach (XmlNode node in document.DocumentElement)
            {
                string imie = node["Imię"].InnerXml;
                string nazwisko = node["Nazwisko"].InnerXml;
                string data = node["DataUr"].InnerXml;
                string AdresStaly = node["AdresStały"].InnerXml;
                string AdresTymczasowy = node["AdresTym"].InnerXml;
                Zajecia lista = new Zajecia();

                XmlNode dziecko = node["ListaZajęć"];
                foreach (XmlNode inner in dziecko)
                {
                    lista.PrzedmiotOcena.Add(inner["Nazwa"].InnerXml, inner["Ocena"].InnerXml);
                }

                Student nowy = new Student(imie, nazwisko, data, AdresStaly, AdresTymczasowy, lista);
                studenci.Add(nowy);
            }
            foreach (var student in studenci)
                Console.WriteLine(student.ToString());
            
        }
    }
}
