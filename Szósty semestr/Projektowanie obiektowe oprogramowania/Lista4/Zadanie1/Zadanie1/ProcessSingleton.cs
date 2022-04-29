using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class ProcessSingleton
    {
        private ProcessSingleton() { }
        private static ProcessSingleton instance = null;
        private static object _lock = new object();

        public static ProcessSingleton Instance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                        instance = new ProcessSingleton();
                }
            }

            return instance;
        }
    }
}
