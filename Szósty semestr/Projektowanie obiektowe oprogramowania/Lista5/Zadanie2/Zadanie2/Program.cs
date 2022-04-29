using System;
using System.IO;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string text = "W Szczebrzeszynie chrząszcz brzmi w trzcinie";

            FileStream fileToWrite = File.Create("./Output.txt");
            CaesarStream caeToWrite = new CaesarStream(fileToWrite, 5);
            var textBytes = System.Text.Encoding.UTF8.GetBytes(text);
            caeToWrite.Write(textBytes);
            fileToWrite.Close();

            FileStream fileToRead = File.OpenRead("./Output.txt");
            CaesarStream caeToRead = new CaesarStream(fileToRead, -5);

            var output = new byte[1000];
            caeToRead.Read(output);
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(output));
        }
    }
}
