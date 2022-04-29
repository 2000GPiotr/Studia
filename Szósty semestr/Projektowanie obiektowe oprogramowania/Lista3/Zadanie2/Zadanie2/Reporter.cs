using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    public class ReportPrinter
    {
        public void PrintReport()
        {
            DataProvider collector = new DataProvider();
            string data = collector.GetData();

            Formatter formatter = new Formatter();
            data = formatter.FormatDocument(data);

            Console.WriteLine("Printing report...");
            Console.WriteLine("Printed: " + data);
        }
    }

    public class DataProvider
    {
        public string GetData()
        {
            Console.WriteLine("Receiving data...");
            return "Some data";
        }
    }

    public class Formatter
    {
        public string FormatDocument(string data)
        {
            Console.WriteLine("Formatting document...");
            return ("Formated: " + data);
        }
    }
}
