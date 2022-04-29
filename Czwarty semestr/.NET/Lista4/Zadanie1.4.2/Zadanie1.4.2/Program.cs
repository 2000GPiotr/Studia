using System;

namespace Zadanie1._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Type wordType = Type.GetTypeFromProgID("Word.Application");

            dynamic w = Activator.CreateInstance(wordType);

            w.Visible = true;
            w.Documents.Add();
            
        }
    }
}
