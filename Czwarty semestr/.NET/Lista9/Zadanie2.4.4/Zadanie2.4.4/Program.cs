using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Zadanie2._4._4
{
    public class Student
    {
        public string name { get; set; }
        public string surname { get; set; }

        public Address address { get; set; }
        public Address tmpaddress { get; set; }

        public Lesson[] Lessons { get; set; }
    }

    public class Address
    {
        public string city { get; set; }
        public string street { get; set; }

    }

    public class Lesson
    {
        public string name{get; set;}
        public string grade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student()
            {
                name = "Adam",
                surname = "Nowak",

                address = new Address()
                {
                    city = "Kraków",
                    street = "Leśna"
                },
                tmpaddress = new Address()
                {
                    city = "Katowice",
                    street = "Długa"
                },
                Lessons = new Lesson[]
                {
                    new Lesson()
                    {
                        name = "aaa",
                        grade = "3"
                    },
                    new Lesson()
                    {
                        name = "aaa",
                        grade = "3"
                    }
                }

            };

            StringBuilder sb = new StringBuilder();
            using (StringWriter sw = new StringWriter(sb))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Student));
                xs.Serialize(sw, student);
            }
            
           // Console.WriteLine(sb);


            XmlSerializer serializer = new XmlSerializer(typeof(Student));

            FileStream fs = new FileStream("./Student.xml", FileMode.OpenOrCreate);
            TextReader reader = new StreamReader(fs);

            Student p = (Student)serializer.Deserialize(reader);

            Console.WriteLine(p.name);
        }
    }
}
