using System;
using System.Xml;
using System.Xml.Schema;

namespace ConsoleApp1
{
    class Program
    {
        static void SettingsValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
            {
                Console.Write("WARNING: ");
                Console.WriteLine(e.Message);
            }
            else if (e.Severity == XmlSeverityType.Error)
            {
                Console.Write("ERROR: ");
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            XmlReaderSettings readerSettings = new XmlReaderSettings();
            readerSettings.Schemas.Add("./", "Student.xsd");

            readerSettings.ValidationType = ValidationType.Schema;
            readerSettings.ValidationEventHandler += new ValidationEventHandler(SettingsValidationEventHandler);

            XmlReader reader = XmlReader.Create("Student.xml", readerSettings);

            while (reader.Read()) ;
        }
    }
}
