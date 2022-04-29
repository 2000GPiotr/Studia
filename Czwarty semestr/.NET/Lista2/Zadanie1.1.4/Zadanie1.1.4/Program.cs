using System;
using System.Reflection;



namespace Zadanie1._1._4
{
    public class OznakowaneAttribute : Attribute{ }
    public class ExampleClass1
    {
        public string Foo()
        {
            return "Foo";
        }
        
        [Oznakowane]
        public int GiveOne()
        {
            Console.WriteLine("1");
            return 1;
        }
        public int GiveTwo()
        {
            Console.WriteLine("2");
            return 2;
        }
        private int GiveThree()
        {
            Console.WriteLine("3");
            return 3;
        }
        public int GiveFour(int a, int b)
        {
            Console.WriteLine("4");
            return 4;
        }
        static public int GiveZero()
        {
            Console.WriteLine("0");
            return 0;
        }
    }
    public class ExampleClass2
    {
        [Oznakowane]
        public int GiveOne()
        {
            Console.WriteLine("1");
            return 1;
        }
        public int GiveTwo()
        {
            Console.WriteLine("2");
            return 2;
        }
        [Oznakowane]
        public int GiveThree()
        {
            Console.WriteLine("3");
            return 3;
        }
        public int GiveFour()
        {
            Console.WriteLine("4");
            return 4;
        }
        [Oznakowane]
        public int GiveZero()
        {
            Console.WriteLine("0");
            return 0;
        }
    }

    class Program
    {
        static void Zadanie(Object O)
        {
            int i = 0;

            MethodInfo[] Methods = O.GetType().GetMethods();

            foreach (MethodInfo metod in Methods)
            {
                if (metod.IsPublic)
                    if (metod.ReturnType == i.GetType())
                    {
                        if (!metod.IsStatic)
                        {
                            ParameterInfo[] parameters = metod.GetParameters();
                            if (parameters.Length == 0)
                            {
                                //Console.WriteLine(metod.Name);
                                OznakowaneAttribute oa = metod.GetCustomAttribute(typeof(OznakowaneAttribute)) as OznakowaneAttribute;
                                if(oa != null)
                                {
                                   // Console.WriteLine(metod.Name);
                                    metod.Invoke(O, null);
                                }
                                    
                            }                                
                        }
                    }
             }
        }
        static void Main(string[] args)
        {
            ExampleClass1 C1 = new ExampleClass1();
            ExampleClass2 C2 = new ExampleClass2();

            Zadanie(C1);
            Console.WriteLine("----------------");
            Zadanie(C2);
        }
    }
}
