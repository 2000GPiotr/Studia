using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Slownik <int, string> s = new Slownik<int, string>();
            s.add(1,"ala");
            s.add(2,"ma");
            s.add(3,"kota");
            s.add(4,"psa");

            Console.WriteLine(s.search(1));
            Console.WriteLine(s.search(2));
            Console.WriteLine(s.search(3));
            Console.WriteLine(s.search(5));

            Console.WriteLine(s.search(1));
            Console.WriteLine(s.search(2));
            Console.WriteLine(s.search(4));

            Console.WriteLine(s.search(1));
            Console.WriteLine(s.search(2));
            Console.WriteLine(s.search(3));
            Console.WriteLine(s.search(4));


            s.delete(3);
            Console.WriteLine(s.search(3));

            Console.WriteLine(s.search(1));
            Console.WriteLine(s.search(2));
            Console.WriteLine(s.search(3));
            Console.WriteLine(s.search(4));
        }
    }
    public class Slownik<K,V>
    {
        K [] keys;
        V [] values;
        int size;
        int countelem;
        int counter;

        public Slownik()
        {
            size = 10;
            keys = new K[size];
            values = new V[size];
            counter = 0;
            countelem = 0;
        }

        public void add(K key, V value)
        {
            if (counter >= 9)
            {
                Array.Resize(ref keys, keys.Length + size);
                Array.Resize(ref values, values.Length + size);
                counter = -1;
            }

            keys[countelem] = key;
            values[countelem] = value;
            countelem++;
            counter++;
        }

        public V search (K key)
        {
            for (int i = 0; i < countelem; i++)
                if (keys[i].Equals(key))
                    return values[i];
            return default(V);
        }

        public void delete(K key)
        {
            int index = Array.IndexOf(keys, key);
            if (index == -1)
                return;             
            
            V[] newValues = new V[countelem - 1];
            K[] newKeys = new K[countelem - 1];

            Array.Copy(keys, 0, newKeys, 0, index);

            Array.Copy(keys, index + 1, newKeys, index, countelem - index - 1);

            Array.Copy(values, 0, newValues, 0, index);
            Array.Copy(values, index + 1, newValues, index, countelem - index - 1);

            keys = newKeys;
            values = newValues;
            countelem--;
        } 


    }
}
