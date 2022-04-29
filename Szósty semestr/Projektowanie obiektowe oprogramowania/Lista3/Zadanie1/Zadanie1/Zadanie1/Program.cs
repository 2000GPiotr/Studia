using System;

namespace Zadanie1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new FactoryOfFoo().Create();

            Cheese cheese = new Cheese() { name = "chedar" };
            Mouse jerry = new Mouse() { name = "Jerry" };
            jerry.eat(cheese);
            
            Printer printer = new Printer();
            printer.Print("Ala ma kota");

            DeriveClass deriveClass = new DeriveClass();
            deriveClass.Foo();
        }
    }
}
