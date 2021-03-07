using System;
using System.Globalization;

namespace _2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex z = new Complex(4, 3);
            Console.WriteLine(String.Format("{0}", z));
            Console.WriteLine(String.Format("{0:d}", z));
            Console.WriteLine(String.Format("{0:w}", z));
            Complex x = new Complex(1, 1);
            x = x + z;
            Console.WriteLine(String.Format("{0}", x));
            x = x * z;
            Console.WriteLine(String.Format("{0}", x));
        }
    }
    class Complex : IFormattable
    {
        private int real, imag;
        public Complex() => real = imag = 0;
        public Complex(int x, int i)
        {
            real = x;
            imag = i;
        }
        public static Complex operator +(Complex a, Complex b) =>
            new Complex(a.real + b.real, a.imag + b.imag);

        public static Complex operator -(Complex a, Complex b) =>
            new Complex(a.real - b.real, a.imag - b.imag);

        public static Complex operator *(Complex a, Complex b) =>
            new Complex(a.real * b.real - a.imag * b.imag, a.real * b.imag + a.imag * b.real);

        public override string ToString()
        {
            return this.ToString("D", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format)) format = "D";
            if (provider == null) provider = CultureInfo.CurrentCulture;
            switch (format.ToUpperInvariant())
            {
                case "D":
                    return real.ToString() + "+" + imag.ToString() + "i";
                case "W":
                    return "[" + real.ToString() + "," + imag.ToString() + "]";
                default:
                    throw new FormatException(String.Format("zly format"));
            }
        }
    }
}
