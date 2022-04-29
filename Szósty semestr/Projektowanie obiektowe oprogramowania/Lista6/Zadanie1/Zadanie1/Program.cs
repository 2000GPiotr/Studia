using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerFactory factory = LoggerFactory.Instance();
            ILogger logger1 = factory.GetLogger(LogType.File, "./foo.txt");
            logger1.Log("foo bar");

            ILogger logger2 = factory.GetLogger(LogType.Console);
            logger2.Log("foo bar");

            ILogger logger3 = factory.GetLogger(LogType.None);
            logger3.Log("foo bar");
        }
    }
}
