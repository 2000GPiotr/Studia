using System;
using System.Globalization;

namespace Zadanie2._3._1
{
    public class Complex : IFormattable
    {
        public decimal a;
        public decimal b;

        public Complex(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
        }
        public static Complex operator +(Complex x, Complex y)
            => new Complex(x.a + y.a, x.b + y.b);
        public static Complex operator -(Complex x, Complex y)
            => new Complex(x.a - y.a, x.b - y.b);
        public static Complex operator *(Complex x, Complex y)
            => new Complex(x.a * y.a - x.b * y.b, x.a * y.b + x.b * y.a);
        public static Complex operator /(Complex x, Complex y)
            => new Complex((x.a*y.a - x.b*y.b)/(y.a*y.a - y.b*y.b), (x.a*y.b + y.a*x.b) / (y.a * y.a - y.b * y.b));
        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format)) format = "G";
            if (provider == null) provider = CultureInfo.CurrentCulture;

            switch(format.ToUpperInvariant())
            {
                case "G":
                case "D":
                    return a.ToString() + " + " + b.ToString() + "i";
                case "W":
                    return "[" + a.ToString() + "," + b.ToString() + "]";
                default:
                    return a.ToString() + " + " + b.ToString() + "i";
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Complex z = new Complex(1, 2);

            Console.WriteLine(String.Format("{0}", z));
            Console.WriteLine(String.Format("{0:d}", z));
            Console.WriteLine(String.Format("{0:w}", z));

        }
    }
}
