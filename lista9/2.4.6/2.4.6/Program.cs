using System;
using System.Xml;

namespace _2._4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = null;

            
            reader = new XmlTextReader("dane.xml");
            reader.WhitespaceHandling = WhitespaceHandling.None;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                    Console.Write(reader.Value + "\t");
                else if (reader.NodeType == XmlNodeType.Element)
                    Console.WriteLine();
            }
          
        }
    }
}
