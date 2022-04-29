 using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie1._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirName = System.IO.Directory.GetCurrentDirectory();

            Console.WriteLine(currentDirName);

            string[] files = System.IO.Directory.GetFiles(currentDirName, "*.*");

            List<int> filelength = new List<int>();

            foreach (var item in files)
            {
                filelength.Add(item.Length);
            }

            int sumlength =
                filelength.Aggregate(0, (sum, next) => sum += next);

            Console.WriteLine(sumlength);

        }
    }
}
