using System;

namespace Trapezy
{
    class Program
    {
        static long Silnia(int x)
        {
            long r = 1;
            for (int i = 1; i <= x; i++)
                r *= i;
            return r;
        }
        static double Erlang(int k, double lamb, double x)
        {
            return (Math.Pow(lamb, k) * Math.Pow(x, k - 1) * Math.Exp(-lamb * x)) / (Silnia(k - 1));
        }

        Func<int, double, double> Erlang = (int k, double lamb, double x) => (Math.Pow(lamb, k) * Math.Pow(x, k - 1) * Math.Exp(-lamb * x)) / (Silnia(k - 1));

        static double Trapezy(double t, int l)
        {
            double res = 0;

            int k = 1;
            double lamb = 0.5;
            double eps = t / l;

            for(double i=0; i<t; i+=eps)
            {
                res += (Erlang(k, lamb, i) + Erlang(k, lamb, i + eps)) * eps / 2;
            }

            return res;
        }

        static void Main(string[] args)
        {
            double w1 = Trapezy(20, 10000);
            Console.WriteLine(w1);
        }
    }
}
