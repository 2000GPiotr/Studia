using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Foo
    {

    }
    public class Bar : Foo
    {

    }
    //Creator
    public class FactoryOfFoo
    {
        public Foo Create()
        {
            return new Bar();
        }
    }
}
