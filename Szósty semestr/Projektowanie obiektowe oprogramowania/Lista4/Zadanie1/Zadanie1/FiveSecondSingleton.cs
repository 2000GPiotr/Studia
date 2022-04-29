using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class FiveSecondSingleton
    {
        private static FiveSecondSingleton instance = null;
        private static object _lock = new object();

        static DateTime createTime;

        private FiveSecondSingleton() { createTime = DateTime.Now; }

        public static FiveSecondSingleton Instance()
        {
            if (instance == null || DateTime.Now >= createTime.AddSeconds(5))
            {
                lock (_lock)
                {
                    if (instance == null || DateTime.Now >= createTime.AddSeconds(5))
                        instance = new FiveSecondSingleton();
                }
            }

            return instance;
        }
    }
}
