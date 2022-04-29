using System;
using System.Collections;

namespace Zadanie4
{
    class Program
    {
        /* this is the Comparison<int> to be converted */
        static int IntComparer(int x, int y)
        {
            return x.CompareTo(y);
        }

        class ComparisonToIComparerAdapter<T> : IComparer
        {

            private Comparison<T> comparison;

            public ComparisonToIComparerAdapter(Comparison<T> comparison)
            {
                this.comparison = comparison;
            }

            public int Compare(object x, object y)
            {
                return comparison((T)x, (T)y);
            }
        }

        static void Main(string[] args)
        {
            ArrayList a = new ArrayList() { 1, 5, 3, 3, 2, 4, 3 };

            /* the ArrayList's Sort method accepts ONLY an IComparer */
            
            var adapter = new ComparisonToIComparerAdapter<int>(IntComparer);
            
            a.Sort(adapter);
            
            foreach (var x in a)
                Console.Write("{0}, ", x);
        }
    }
}
