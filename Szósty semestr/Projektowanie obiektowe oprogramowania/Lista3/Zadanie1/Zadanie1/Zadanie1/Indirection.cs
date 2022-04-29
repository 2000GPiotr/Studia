using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class BaseClass
    {
        public void Foo()
        {
            Console.WriteLine("foo");
        }
    }
    class DeriveClass
    {
        public void Foo()
        {
            BaseClass delegated = new BaseClass();
            delegated.Foo();
        }
    }
}

