using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class ThreadSingleton
    {
        private static ThreadLocal<ThreadSingleton> localInstance = new ThreadLocal<ThreadSingleton>();
        private ThreadSingleton(){}

        public static ThreadSingleton Instance()
        {
            if (localInstance.Value == null)
            {
                localInstance.Value = new ThreadSingleton();
            }
            return localInstance.Value;
        }
    }
}
