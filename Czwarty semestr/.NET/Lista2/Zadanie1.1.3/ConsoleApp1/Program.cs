using System;
using System.Reflection;

namespace ConsoleApp1
{
    public class Person
    {
        private string _imie;
        private int _wiek;

        public string Nazwisko;

        public Person(string n)
        {
            this._imie = n;
        }
        public Person(string n, int w)
        {
            this._imie = n;
            this._wiek = w;
        }
        public string Imie
        {
            get { return _imie; }
            set { this._imie = value; }
        }
        public override string ToString()
        {
            return (_imie + _wiek);
        }
        public string MyToString()
        {
            return (_imie + '_' + _wiek);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person osoba = new Person("Jan", 28);
            //Console.WriteLine(osoba.Imie);
            osoba.Nazwisko = "Kowalski";
            //  Console.WriteLine(osoba.GetType().GetProperty("Imie").GetValue("_imie"));
            //Console.WriteLine(osoba.ToString());
            Type osobatype = osoba.GetType();

            //Console.WriteLine(osobatype.GetMethod("MyToString").Invoke(osoba, null));
            //Console.WriteLine(osobatype.GetField("_imie").GetValue(osoba));

            
            PropertyInfo property = osoba.GetType().GetProperty("Imie");

            property.GetCustomAttributes();

            
            #region PomiarCzasu

            osoba.Nazwisko = "Kowalski";

            DateTime Start1 = DateTime.Now;

            int LiczbaProb = 1; // 100000;

            for (int i = 0; i < LiczbaProb; i++)
            {
                Console.WriteLine(osoba.Nazwisko);
            }

            DateTime Stop1 = DateTime.Now;
            TimeSpan c1 = Stop1 - Start1;


            DateTime Start2 = DateTime.Now;

            for (int i = 0; i < LiczbaProb; i++)
            {
                Console.WriteLine(osobatype.GetField("Nazwisko").GetValue(osoba));
            }

            DateTime Stop2 = DateTime.Now;
            TimeSpan c2 = Stop2 - Start2;

            Console.WriteLine("Czas dostępu w zwykły sposób: "+ c1.ToString());
            Console.WriteLine("Czas dostępu przez refleksje: " + c2.ToString());

            #endregion PomiarCzasu
        }
    }
}
