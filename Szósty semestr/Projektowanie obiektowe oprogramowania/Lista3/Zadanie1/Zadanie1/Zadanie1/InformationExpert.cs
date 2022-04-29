using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Mouse
    {
        public string name;
        public void eat(Cheese cheese)
        {
            Console.WriteLine("Omnomnom very tasety " + cheese.name + ". I'm " + this.name + " and I eat it.");
        }
    }
    public class Cheese
    {
        public string name;
    }
}
