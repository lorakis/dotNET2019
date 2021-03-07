using System;
using System.Xml;
using System.IO;

namespace _2._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FileStream fs = new FileStream("dane.xml", FileMode.Open);
            XmlTextReader xr = new XmlTextReader(fs);
            while (xr.Read())
            {
                XmlNodeType t = xr.NodeType;
                if (t == XmlNodeType.Element)
                {
                    Console.WriteLine("\t<{0}>", xr.Name);
                    if (xr.HasAttributes)
                        while (xr.MoveToNextAttribute())
                            Console.WriteLine("\t\t[{0}]{1}", xr.Name, xr.Value);
                }
                if (t == XmlNodeType.Text)
                    Console.WriteLine("Tekst: {0}", xr.Value);
            }
            xr.Close();
        }
    }
}
