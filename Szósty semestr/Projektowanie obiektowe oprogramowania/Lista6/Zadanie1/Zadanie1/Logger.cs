using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public interface ILogger
    {
        void Log(string Message);
    }
    public class NoneLogger : ILogger
    {
        public void Log(string Message){}
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string Message)
        {
            Console.WriteLine(Message);
        }
    }

    public class FileLogger : ILogger
    {
        private StreamWriter file;
        public FileLogger(string fileName)
        {
            if (fileName == null)
                throw new ArgumentException("Niepoprawna ścieżka");
            this.file = new StreamWriter(fileName, append: true);
        }
        public void Log(string Message)
        {
            using(file)
            {
                file.WriteLine(Message);
            }            
        }
    }

    public enum LogType { None, Console, File}
    class LoggerFactory
    {
        private LoggerFactory() { }
        private static LoggerFactory instance;
        public ILogger GetLogger(LogType LogType, string parameter=null)
        {
            switch (LogType)
            {
                case LogType.None: return new NoneLogger();
                case LogType.Console: return new ConsoleLogger();
                case LogType.File: return new FileLogger(parameter);
                default: throw new ArgumentException("Niepooprawny typ");
            }
        }
        public static LoggerFactory Instance()
        {
            if (instance is null)
                instance = new LoggerFactory();

            return instance;
        }

    }
}
