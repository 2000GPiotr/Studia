using System;
using System.Text;

namespace Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new IntStream();
            Console.WriteLine("Koeljne liczby");
            Console.WriteLine(ints.next());
            Console.WriteLine(ints.next());
            Console.WriteLine(ints.next());
            Console.WriteLine(ints.next());
            Console.WriteLine("Hello ");

            var prms = new PrimeStream();
            Console.WriteLine("Kolejne pierwsze");
            Console.WriteLine(prms.next());
            Console.WriteLine(prms.next());
            Console.WriteLine(prms.next());
            Console.WriteLine(prms.next());
            Console.WriteLine(prms.next());
            Console.WriteLine(prms.next());

            var rnds = new RandomStream();
            Console.WriteLine("Liczby losowe");
            Console.WriteLine(rnds.next());
            Console.WriteLine(rnds.next());
            Console.WriteLine(rnds.next());
            Console.WriteLine(rnds.next());

            var rws = new RandomWordStream();
            Console.WriteLine("Losowe ciagi");
            Console.WriteLine(rws.next());
            Console.WriteLine(rws.next());
            Console.WriteLine(rws.next());
        }
    }

    public class IntStream
    {
        public int act;
        public IntStream()
        {
            act=-1;
        }

        virtual public int next()
        {
            if(eos()==false)
            {
                return this.act+=1;
            }
            else
            {
                Console.WriteLine("Nie mozna zwiekszyc liczby, przekroczono zakres");
                return act;
            }
        }

        virtual public bool eos()
        {
            if(act<=Int32.MaxValue)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        virtual public void reset()
        {
            act=-1;
        }
    }

    public class PrimeStream: IntStream
    {
        public PrimeStream()
        {
            act=1;
        }

        bool czy_pierwsza(int n)
        {
            for(int i=2; i*i<=n; i++)
            {
                if(n%i==0)
                    return false;
            }
            return true;
        }

        public override int next()
        {
            if(eos()==true)
                Console.WriteLine("Przekroczono zakres");

            act++;
            while(czy_pierwsza(act)==false)
            {
                if(eos()==true)
                {
                    Console.WriteLine("Przekroczono zakres");
                    break;
                }
                else
                    act++;
            }
            return act;
        }
        public override void reset()
        {
            act=1;
        }
    }

    public class RandomStream: IntStream
    {
	    Random rands = new Random();
	    public RandomStream()
        {
		    act = 0;
	    }
	    override public int next()
        {
		    if(eos()==true)
            {
                Console.WriteLine("Przekroczono zakres");
            }
            else
            {
                act = rands.Next(0,26);
            }
		    return act;
	    }
        override public bool eos()
        {
            return false;
        }
    }
    public class RandomWordStream
    {
        PrimeStream prms = new PrimeStream();
        RandomStream rnds = new RandomStream();
        public String next()
        {
            String w="";
            int dl=prms.next();
            for(int i=0; i<dl; i++)
            {
                char l=(char)('a'+rnds.next());
                w=w+l;
            }
            return w;
        }
    }
}
