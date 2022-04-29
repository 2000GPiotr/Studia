using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie1._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new { Field1 = "The value", Field2 = 5};
            var item2 = new { Field1 = "Value", Field2 = 6 };


            var list = new[] { item}.ToList();
            list.Add(item2);

            Console.WriteLine(  list.GetType());

            foreach (var it in list)
            {
                Console.WriteLine(it.Field1 + ' ' + it.Field2);
            }
        }
    }
}
