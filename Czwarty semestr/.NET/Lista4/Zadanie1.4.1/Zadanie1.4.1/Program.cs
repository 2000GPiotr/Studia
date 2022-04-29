using System;

namespace Zadanie1._4._1
{
    class Program
    {
        static int Foo(int x, int y)
        {
            int res;

            res = x + y;
            res += y;
            res += y;

            return res;
        }

        static dynamic Boo(dynamic x,dynamic y)
        {
            dynamic res;

            res = x + y;
            res += y;
            res += y;

            return res;
        }

        static void Main(string[] args)
        {
            DateTime Start1 = DateTime.Now;

            dynamic a = Boo(12, 12);

            DateTime Stop1 = DateTime.Now;
            TimeSpan ts1 = Stop1 - Start1;

            //============================================

            DateTime Start2 = DateTime.Now;

            int b = Foo(12, 12);

            DateTime Stop2 = DateTime.Now;
            TimeSpan ts2 = Stop2 - Start2;

            //============================================

            DateTime Start3 = DateTime.Now;

            dynamic c = Boo("Ala ", "ma kota");

            DateTime Stop3 = DateTime.Now;
            TimeSpan ts3 = Stop2 - Start2;

            //==============================================

            DateTime Start4 = DateTime.Now;

            dynamic d = Boo(12, 12);

            DateTime Stop4 = DateTime.Now;
            TimeSpan ts4 = Stop2 - Start2;


            Console.WriteLine("dynamic a = Boo(12, 12) " + ts1);
            Console.WriteLine("int b = Foo(12, 12) " + ts2);
            Console.WriteLine("dynamic c = Boo(\"Ala \", \"ma kota\") " + ts3);
            Console.WriteLine("dynamic d = Boo(12, 12) " + ts4);


        }
    }
}
