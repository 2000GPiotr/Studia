using System;
using System.Collections.Generic;

namespace Zadanie_1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            
            l.Add("Ala ");
            l.Add("ma ");
            l.Add("kota ");
            l.Add("Ola ");
            l.Add("ma ");
            l.Add("psa ");
            l.Add("Ula ");
            l.Add("ma ");
            l.Add("mak ");

            foreach (var item in l)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");

            List<string> list = l.FindAll(s => s.Contains("m"));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");

            List<string> list1 = l;
            list1.RemoveAll(s => s.Contains("m"));
            
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");


            List<char> list2 = new List<char> { 'a', 'b', 'c' };

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");

            List<int> list3 = list2.ConvertAll(c => (int)c );

            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");


            list3.ForEach(i => Console.WriteLine(i+10));

            Console.WriteLine("==========================");


            List<int> list4 = new List<int>() { 1, 3, 7, 3, 8, 9, 3, 2, 12, 321, 32, 0 };
            list4.Sort();

            foreach (var item in list4)
            {
                Console.WriteLine(item);
            }

        }
    }
}
