using System;
using System.Collections;
using System.Collections.Generic;

namespace Zadanie1._2._1
{
    class Program
    {
        static void BenchmarkList()
        {
            #region ArrayList-List
            ArrayList al = new ArrayList();
            List<String> ls = new List<string>();

            int length = 100000;

            #region AddTime

            DateTime Start1 = DateTime.Now;
            for (int i = 0; i < length; i++)
            {
                al.Add("Hi!");
            }
            DateTime Stop1 = DateTime.Now;

            TimeSpan ts1 = Stop1 - Start1;


            DateTime Start2 = DateTime.Now;
            for (int i = 0; i < length; i++)
            {
                ls.Add("Hi!");
            }
            DateTime Stop2 = DateTime.Now;

            TimeSpan ts2 = Stop2 - Start2;


            Console.WriteLine("Czas Add ArrayList: " + ts1);
            Console.WriteLine("Czas Add List: " + ts2);
            #endregion AddTime

            Console.WriteLine("---------------------");

            #region SeeTime

            DateTime StartSee1 = DateTime.Now;

            foreach (var item in al)
            {
                item.GetType();
            }

            DateTime StopSee1 = DateTime.Now;
            TimeSpan tss1 = StopSee1 - StartSee1;


            DateTime StartSee2 = DateTime.Now;
            foreach (var item in ls)
            {
                item.GetType();
            }
            DateTime StopSee2 = DateTime.Now;
            TimeSpan tss2 = StopSee2 - StartSee2;

            Console.WriteLine("Czas See ArrayList: " + tss1);
            Console.WriteLine("Czas See List: " + tss2);

            #endregion SeeTime

            Console.WriteLine("---------------------");

            #region DeleteTime

            DateTime Startd1 = DateTime.Now;
            for (int i = 0; i < length; i++)
            {
                al.Remove("Hi!");
            }
            DateTime Stopd1 = DateTime.Now;

            TimeSpan tsd1 = Stopd1 - Startd1;


            DateTime Startd2 = DateTime.Now;
            for (int i = 0; i < length; i++)
            {
                ls.Remove("Hi!");
            }
            DateTime Stopd2 = DateTime.Now;

            TimeSpan tsd2 = Stopd2 - Startd2;


            Console.WriteLine("Czas Delete ArrayList: " + tsd1);
            Console.WriteLine("Czas Delete List: " + tsd2);
            #endregion DeleteTime
            #endregion ArrayList-List
        }

        static void BenchmarkDictionary()
        {
           #region Hashtable-Dictionary
           Hashtable ht = new Hashtable();
           Dictionary<int, string> dict = new Dictionary<int,string>();

           int length = 100000;

           #region AddTime

           DateTime Start1 = DateTime.Now;
           for (int i = 0; i < length; i++)
           {
               ht.Add(i, "Hi!");
           }
           DateTime Stop1 = DateTime.Now;

           TimeSpan ts1 = Stop1 - Start1;


           DateTime Start2 = DateTime.Now;
           for (int i = 0; i < length; i++)
           {
               dict.Add(i,"Hi!");
           }
           DateTime Stop2 = DateTime.Now;

           TimeSpan ts2 = Stop2 - Start2;


           Console.WriteLine("Czas Add Hashtable: " + ts1);
           Console.WriteLine("Czas Add Dictionery: " + ts2);
           #endregion AddTime

           Console.WriteLine("---------------------");

           #region SeeTime

           DateTime StartSee1 = DateTime.Now;

           foreach (var item in ht)
           {
               item.GetType();
           }

           DateTime StopSee1 = DateTime.Now;
           TimeSpan tss1 = StopSee1 - StartSee1;


           DateTime StartSee2 = DateTime.Now;
           foreach (var item in dict)
           {
               item.GetType();
           }
           DateTime StopSee2 = DateTime.Now;
           TimeSpan tss2 = StopSee2 - StartSee2;

           Console.WriteLine("Czas See Hashtable: " + tss1);
           Console.WriteLine("Czas See Dictionery: " + tss2);

           #endregion SeeTime

           Console.WriteLine("---------------------");

           #region DeleteTime

           DateTime Startd1 = DateTime.Now;
           for (int i = 0; i < length; i++)
           {
               ht.Remove(i);
           }
           DateTime Stopd1 = DateTime.Now;

           TimeSpan tsd1 = Stopd1 - Startd1;


           DateTime Startd2 = DateTime.Now;
           for (int i = 0; i < length; i++)
           {
               dict.Remove(i);
           }
           DateTime Stopd2 = DateTime.Now;

           TimeSpan tsd2 = Stopd2 - Startd2;


           Console.WriteLine("Czas Delete Hashtable: " + tsd1);
           Console.WriteLine("Czas Delete Dictionery: " + tsd2);
           #endregion DeleteTime
           #endregion Hashtable-Dictionary
        }
        static void Main(string[] args)
        {

            BenchmarkList();
            Console.WriteLine("===============================");
            BenchmarkDictionary();
          
        }
    }
}
