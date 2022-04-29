using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@".\Liczby.txt");
            List<int> intlines = new List<int>();

            for(int i =0; i<lines.Length; i++)
            {
                intlines.Add(Convert.ToInt32(lines[i]));
            }
            
            IEnumerable<int> finallist =
                from number in intlines
                where number > 100
                orderby number ascending
                select number;

            IEnumerable<int> finallist2 = 
                (intlines
                            .Where(a => a > 100)
                            .OrderBy(v => v));


            foreach (var item in intlines)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("=======================");
            foreach (var item in finallist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=======================");
            foreach (var item in finallist2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
