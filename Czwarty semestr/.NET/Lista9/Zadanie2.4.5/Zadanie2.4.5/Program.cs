using System;
using System.Xml;

namespace Zadanie2._4._5
{
    class Program
    {
        // na podstawie podręcznika
        public static void InfoOWezle(XmlNode node)
        {
            Console.WriteLine("Węzeł typu {0}", node.NodeType);
            if (node.NodeType == XmlNodeType.Element)
            {
                Console.WriteLine("\t<{0}>", node.Name);
                foreach (XmlAttribute a in node.Attributes)
                    Console.WriteLine("\t\t[{0}]{1}", a.Name, a.Value);
            }
            if (node.NodeType == XmlNodeType.Text)
                Console.WriteLine("Tekst: {0}", node.Value);
            foreach (XmlNode child in node.ChildNodes)
                InfoOWezle(child);
        }

        public static void AddStudent(XmlDocument xml)
        {
            XmlElement studentElement = xml.CreateElement("Student");

            XmlAttribute attribute;

            attribute = xml.CreateAttribute("name");
            attribute.Value = "Adam";
            studentElement.Attributes.Append(attribute);

            attribute = xml.CreateAttribute("surname");
            attribute.Value = "Nowak";
            studentElement.Attributes.Append(attribute);

            XmlElement addresElement = xml.CreateElement("address");
            
            attribute = xml.CreateAttribute("city");
            attribute.Value = "Sopot";
            addresElement.Attributes.Append(attribute);

            attribute = xml.CreateAttribute("street");
            attribute.Value = "Wielka";
            addresElement.Attributes.Append(attribute);

            studentElement.AppendChild(addresElement);

            XmlElement tmpaddresElement = xml.CreateElement("tmpaddress");

            attribute = xml.CreateAttribute("city");
            attribute.Value = "Legnica";
            tmpaddresElement.Attributes.Append(attribute);

            attribute = xml.CreateAttribute("street");
            attribute.Value = "Mała";
            tmpaddresElement.Attributes.Append(attribute);

            studentElement.AppendChild(tmpaddresElement);


            XmlElement gradeElement = xml.CreateElement("subject");

            attribute = xml.CreateAttribute("name");
            attribute.Value = "aaaa";
            gradeElement.Attributes.Append(attribute);

            attribute = xml.CreateAttribute("grade");
            attribute.Value = "2";
            gradeElement.Attributes.Append(attribute);

            studentElement.AppendChild(gradeElement);


            gradeElement = xml.CreateElement("subject");

            attribute = xml.CreateAttribute("name");
            attribute.Value = "bbbb";
            gradeElement.Attributes.Append(attribute);

            attribute = xml.CreateAttribute("grade");
            attribute.Value = "2";
            gradeElement.Attributes.Append(attribute);


            studentElement.AppendChild(gradeElement);

            xml.AppendChild(studentElement);
        }

        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("Student.xml");
            InfoOWezle(xml);

            AddStudent(xml);

        }
    }
}
