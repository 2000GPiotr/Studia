using System;
using System.Collections;

namespace Zadanie2._3._2
{
    public class Set : ArrayList
    {
        public override int Add(object value)
        {
            if(this.Contains(value))
            {
                return -1;
            }
            else
            {
                return base.Add(value);
            }         
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Set s = new Set
            {21, 32, 32, 32, 32, "Ala", 4, 5, 4, 32, 4, "Ala", "Ola", 4, 1, 1, 1, 1 
            };

            foreach (var i in s)
                Console.WriteLine( i);
            Console.WriteLine("========================");

            s.Add(1);
            s.Add("Ola");
            s.Add("Anna");
            s.Add(1410);
            s.Add('t');
            s.Add("t");

            foreach (var i in s)
                Console.WriteLine(i);
            Console.WriteLine("========================");
        }
    }
}
