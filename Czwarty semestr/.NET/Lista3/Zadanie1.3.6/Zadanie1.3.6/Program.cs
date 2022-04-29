using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie1._3._6
{
    class Log
    {
        public string date;
        public string IP;
        public Log(string d, string i)
        {
            this.date = d;
            this.IP = i;
        }
        public override string ToString()
        {
            return this.date + ' ' + this.IP;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@".\Logi.txt");

            List<Log> logs = new List<Log>();

            foreach (var line in lines)
            {
                string[] vals = line.Split(' ');
                logs.Add(new Log(vals[0], vals[1]));
            }

            foreach (var item in logs)
            {
                Console.WriteLine(item.ToString());
            }

            var grouped =
                    from log in logs
                    group log by log.IP;

            Func<String, Tuple<String, int>> freq = (item) => new Tuple<String, int>(item, logs.Aggregate(0, (sum, next) => next.IP == item ? sum + 1 : sum));

            var res =
               from i in grouped
               orderby freq(i.Key).Item2 descending
               select i;

            var Result = new[] { freq(res.ElementAt(0).Key), freq(res.ElementAt(1).Key), freq(res.ElementAt(2).Key) };

            foreach (var item in Result)
            {
                Console.WriteLine(item.Item1 + ' ' + item.Item2);
            }

        }
    }
}
