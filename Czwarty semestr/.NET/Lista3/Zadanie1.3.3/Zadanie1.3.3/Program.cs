using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie1._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] NamesInput = System.IO.File.ReadAllLines(@".\Nazwiska.txt");
            List<string> Names = new List<string>();

            for(int i=0; i< NamesInput.Length; i++)
            {
                Names.Add(NamesInput[i]);
            }

            var FirstLetters =
                from name in Names
                orderby name ascending
                group name by name[0];

            foreach (var item in FirstLetters)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
