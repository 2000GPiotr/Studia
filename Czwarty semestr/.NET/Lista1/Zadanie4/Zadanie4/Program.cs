using System;

namespace Zadanie4
{
    class Person
    {
        public string Name, Surname;
        private int _age;
        public int Age
        {
            get { return this._age; }

            set { this._age = value; }
        }

        public override string ToString()
        {
            return Name + ' ' + Surname;
        }

    }
    class Program
    {
        static public Person[] Fillup()
        {
            Person[] people = new Person[10];
            for(int i = 0; i<10; i++)
            {
                string name = "Jan", surname = "Kowalski";
                string name1 = "Leon", surname1 = "Zawodowiec";
                int a = 30;

                Person per = new Person();

                if(i%2 == 1)
                {
                    per.Name = name;
                    per.Surname = surname;
                    per.Age = a;
                }
                else
                {
                    per.Name = name1;
                    per.Surname = surname1;
                    per.Age = a;
                }
                people[i] = per;

                
            }
            return people;
        }
        static void Main(string[] args)
        {
            Person pers = new Person();
            pers.Name = "Jan";
            pers.Surname = "Kowalski";
            Console.WriteLine(pers.ToString());
            pers.Age = 20;
            Console.WriteLine(pers.Age);
            Console.WriteLine("---------------------");

            Person[] people = new Person[10];
            people = Fillup();

            for(int i = 0; i< 10; i++)
            {
                Console.WriteLine(people[i].ToString());
            }

        }
    }
}
