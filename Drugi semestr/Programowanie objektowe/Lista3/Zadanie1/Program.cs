using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> l = new Lista<int>();
            l.addfirst(1);
            l.addfirst(2);
            l.addfirst(3);

            l.printList();

            l.addlast(12);
            l.addlast(14);
            l.addlast(16);
            
            l.printList();

            Console.Write("Usunieto pierwszy element o wartosci: ");
            Console.WriteLine(l.deletefirst());
            l.printList();

            Console.Write("Usunieto ostatni element o wartosci: ");
            Console.WriteLine(l.deletelast());
            l.printList();

        }
    }

    public class Lista<T>
    {
        class Elem
        {
            public T val;
            public Elem next;
            public Elem prev;

            public Elem(T val)
            {
                this.prev=null;
                this.next=null;
                this.val=val;
            }
        }
        
        Elem first;

        public Lista()
        {
            first=null;
        }

        public void printList()
        {
            Elem act = first;
            while (act != null)
            {
                Console.Write(act.val);
                Console.Write(" ");
                act = act.next;
            }
            Console.WriteLine();
        }

        public void addfirst(T val)
        {
            Elem newelem=new Elem(val);

            if(first == null)
            {
                first=newelem;
                return;
            } 
            else if(first.next==null)
            {
                newelem.prev=first;
                newelem.next=first;
                first.prev=newelem;
                first=newelem;
                return;
            }
            else
            {
                newelem.next=first;
                newelem.prev=first.prev;
                first.prev=newelem;
                first=newelem;
                return;
            }
        }

        public void addlast(T val)
        {
            Elem newelem = new Elem(val);

            if (first == null)
            {
                first = newelem;
                return;
            }
            else if (first.next == null)
            {
                first.prev = newelem;
                first.next = newelem;
                newelem.prev = first;
                return;
            }
            else
            {
                first.prev.next = newelem;
                newelem.prev = first.prev;
                first.prev = newelem;                          
                return;
            }
        }
        public T deletefirst()
        {
            if (first.next == null)
            {
                T valret = first.val;
                first = null;
                return valret;
            }
            else
            {
                T valret = first.val;
                first.next.prev = first.prev; 
                first = first.next;          
                return valret;
            }
        }
        public T deletelast()
        {
            if (first.next == null)
            {
                T valret = first.val;
                first = null;
                return valret;
            }
            else
            {
                T valret = first.prev.val;
                first.prev.prev.next = null;
                first.prev = first.prev.prev;
                return valret;                                              
            } 

        }

    } 
}
