using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie1._3._5
{
    public class Person
    {
        public string Imie;
        public string Nazwisko;
        public string PESEL;
    }
    public class BankAccount
    {
        public string PESEL;
        public string NrKonta;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] DataLine = System.IO.File.ReadAllLines(@".\Dane.txt");
            string[] KontoLina = System.IO.File.ReadAllLines(@".\Konta.txt");

            List<Person> persons = new List<Person>();
            List<BankAccount> accounts = new List<BankAccount>();

            #region init
            foreach (var line in DataLine)
            {
                string[] Data = line.Split(' ');
                
                Person person = new Person();
                person.Imie = Data[0];
                person.Nazwisko = Data[1];
                person.PESEL = Data[2];

                persons.Add(person);
            }

            foreach (var line in KontoLina) 
            {
                string[] Data = line.Split(' ');

                BankAccount account = new BankAccount();
                account.PESEL = Data[0];
                account.NrKonta = Data[1];

                accounts.Add(account);
            }
            #endregion init

            var result =
                from person in persons
                join acc in accounts on person.PESEL equals acc.PESEL
                select new {Name = person.Imie, Surname = person.Nazwisko, PESEL = person.PESEL, NrKonta = acc.NrKonta};

            foreach (var item in result)
            {
                Console.WriteLine("Imie: {0}, Nazwisko: {1}, PESEL: {2}, NrKonta: {3}", item.Name, item.Surname, item.PESEL, item.NrKonta);
            }
        }
    }
}
