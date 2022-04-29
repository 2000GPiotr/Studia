using System;
using System.Collections.Generic;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaLeniwa l = new ListaLeniwa();
            Console.WriteLine("Test dla listy leniwej");
            Console.WriteLine(l.element(2));
            Console.WriteLine(l.element(4));
            Console.WriteLine(l.element(6));
            Console.WriteLine(l.element(2));

            Pierwsze p = new Pierwsze();
            Console.WriteLine("Testy pierwsza");
            Console.WriteLine(p.size());
		    Console.WriteLine(p.element(1));
		    Console.WriteLine(p.element(2));
		    Console.WriteLine(p.element(3));
		    Console.WriteLine(p.element(5));
		    Console.WriteLine(p.element(30));
		    Console.WriteLine(p.size());
            Console.WriteLine(p.element(22));
		    Console.WriteLine(p.element(18));
		    Console.WriteLine(p.size());
            
        }
    }

    public class ListaLeniwa
    {
        public List<int> lista=new List<int>();
        public int rozmiar;
        Random los = new Random();

        public int size()
        {
            return rozmiar;
        }
        virtual public int dopisz()
        {
            return los.Next();
        }
        public int element(int i)
        {
            if(i<=rozmiar)
                return lista[i-1];
            while(rozmiar<i)
            {
                lista.Add(dopisz());
                rozmiar++;
            }
            return lista[i-1];
        }
    }
    public class Pierwsze: ListaLeniwa
    {
        bool czy_pierwsza(int n)
        {
            for(int i=2; i*i<=n; i++)
            {
                if(n%i==0)
                    return false;
            }
            return true;
        }
        public override int dopisz()
        {
            if (size()==0)
            {
			    return 2;
		    }
		    int poz = lista[size()-1] +1;
		    
            while(!czy_pierwsza(poz))
		    {
				poz++;
		    }
		    return poz;
        }
    }
}
