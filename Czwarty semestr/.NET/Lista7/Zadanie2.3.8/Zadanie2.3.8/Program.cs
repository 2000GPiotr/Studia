using System;
using System.Collections.Generic;
using System.Globalization;

namespace Zadanie2._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            

            CultureInfo myCI = new CultureInfo("en-US");
            CultureInfo plCult = new CultureInfo("pl-pl");
            CultureInfo deCult = new CultureInfo("de-de");
            CultureInfo frCult = new CultureInfo("fr-fr");
            CultureInfo ruCult = new CultureInfo("ru-RU");
            CultureInfo arCult = new CultureInfo("ar-Sa");
            CultureInfo czCult = new CultureInfo("cs-CZ");

            List<CultureInfo> listOfCulture = new List<CultureInfo>();
            listOfCulture.Add(myCI);
            listOfCulture.Add(plCult);
            listOfCulture.Add(deCult);
            listOfCulture.Add(frCult);
            listOfCulture.Add(ruCult);
            listOfCulture.Add(arCult);
            listOfCulture.Add(czCult);


            //Console.WriteLine(dt);

            foreach (var culture in listOfCulture)
            {
                Console.WriteLine(culture.Name);

                for (int i = 1; i <= 12; i++)
                {
                    DateTime dt = new DateTime(2021, i, 1);
                    Console.WriteLine(dt.ToString("MMMM", culture) + ' ' + dt.ToString("MMM", culture));
                }
                
                Console.WriteLine("==========================================");
                
                for (int i = 1; i < 8; i++)
                {
                    DateTime dt = new DateTime(2021, 1, i);
                    Console.WriteLine(dt.ToString("dddd", culture) + ' ' + dt.ToString("ddd", culture));
                }
                Console.WriteLine("==========================================");
                
                DateTime timeNow = DateTime.Now;
                Console.WriteLine(timeNow.ToString("D", culture));

                Console.WriteLine("==========================================");
                Console.WriteLine("==========================================");
            }

            
        }
    }
}
