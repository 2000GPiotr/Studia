using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Printer
    {
        static string CreateHeading()
        {
            return "Example heading";
        }

        static string CreateFooter()
        {
            return "Example footer";
        }

        static string ProcessText(string text)
        {
            return String.Format("{0} \n{1} \n{2}", CreateHeading(), text, CreateFooter());
        }
        public void Print(string text)
        {
            Console.WriteLine(ProcessText(text));
        }
    }
}
