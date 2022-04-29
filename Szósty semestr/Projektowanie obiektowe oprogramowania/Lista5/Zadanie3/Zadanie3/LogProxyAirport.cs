using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class LogProxyAirport : IAirport
    {
        private Airport airport;
        public LogProxyAirport(int c)
        {
            this.airport = new Airport(c);
        }
        public Plane AcquirePlane()
        {
            Console.WriteLine("Data: {0}, Metoda: AcquirePlane, Parametry: ", DateTime.Now);
            var res = airport.AcquirePlane();
            Console.WriteLine("Data: {0}, Zwrócono: {1}", DateTime.Now, res);
            return res;
        }

        public void RelasePlane(Plane plane)
        {
            Console.WriteLine("Data: {0}, Metoda: RelasePlane, Parametry: {1}", DateTime.Now, plane);
            airport.RelasePlane(plane);
            Console.WriteLine("Data: {0}, Zwrócono: ", DateTime.Now);
        }
    }
}
