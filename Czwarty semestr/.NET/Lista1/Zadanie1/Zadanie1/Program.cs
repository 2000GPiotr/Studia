using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1, b=100000;
            bool f = true;
            int sum = 0;

            for(int i=a; i<=b; i++)
            {
                f = true;
                int pom = i;
                int pomoc = i;
                sum = 0;
                
                while(pomoc > 0)
                {
                    sum += pomoc % 10;
                    pomoc /= 10;
                }

                if (i % sum != 0)
                    f = false;
                
                while(pom>0)
                {
                    int p = pom % 10;
                    if (p == 0)
                    {
                        f = false;
                        break;
                    }
                    if (i % p != 0)
                        f = false;
                    pom = pom / 10;
                }
                if(f == true)
                    Console.WriteLine(i);
            }   
        }
    }
}
