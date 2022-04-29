using System;
using System.IO;
using System.Text;
using System.Xml;

namespace Zadanie2._4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("Student.xml", FileMode.Open);
            XmlTextReader xr = new XmlTextReader(fs);
            while (xr.Read())
            {
                XmlNodeType t = xr.NodeType;
                Console.WriteLine("Węzeł typu {0}", t);
                if (t == XmlNodeType.Element)
                {
                    Console.WriteLine("\t<{0}>", xr.Name);
                    if (xr.HasAttributes)
                        while (xr.MoveToNextAttribute())
                            Console.WriteLine("\t\t[{0}]{1}", xr.Name, xr.Value);
                }
                if (t == XmlNodeType.Text)
                    Console.WriteLine("Tekst: {0}", xr.Value);
            }
            xr.Close();
            Console.WriteLine('\n' + "===========================" + '\n');
            StringBuilder sb = new StringBuilder();
            using(StringWriter sw = new StringWriter(sb))
            using(XmlTextWriter xtw = new XmlTextWriter(sw))
            {
                xtw.WriteStartDocument();

                xtw.WriteStartElement("Student");
                xtw.WriteAttributeString("name", "Jan");
                xtw.WriteAttributeString("surname", "Kowalski");
                xtw.WriteAttributeString("age", "20");

                xtw.WriteStartElement("Address");
                xtw.WriteAttributeString("city", "Wroclaw");
                xtw.WriteAttributeString("street", "Dworcowa");
                xtw.WriteEndElement();

                xtw.WriteStartElement("TmpAddress");
                xtw.WriteAttributeString("city", "Warszawa");
                xtw.WriteAttributeString("street", "Dwolna");
                xtw.WriteEndElement();

                xtw.WriteStartElement("Lessons");

                xtw.WriteStartElement("Lesson");
                xtw.WriteAttributeString("name", "przedmiot1");
                xtw.WriteAttributeString("grade", "5");
                xtw.WriteEndElement();

                xtw.WriteStartElement("Lesson");
                xtw.WriteAttributeString("name", "przedmiot2");
                xtw.WriteAttributeString("grade", "3");
                xtw.WriteEndElement();

                xtw.WriteStartElement("Lesson");
                xtw.WriteAttributeString("name", "przedmiot3");
                xtw.WriteAttributeString("grade", "1");
                xtw.WriteEndElement();

                xtw.WriteEndElement();

                xtw.WriteEndElement();
                xtw.WriteEndDocument();
            }

            Console.WriteLine(sb);
        }
    }
}
