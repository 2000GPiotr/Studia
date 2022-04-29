using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public class ProtectProxyAirport : IAirport
    {
        private Airport airport;
        public ProtectProxyAirport(int c)
        {
            this.airport = new Airport(c);
        }
        public Plane AcquirePlane()
        {
            if(!IsValid())
            {
                throw new Exception();
            }
            return airport.AcquirePlane();
        }

        public void RelasePlane(Plane plane)
        {
            if (!IsValid())
            {
                throw new Exception();
            }
            airport.RelasePlane(plane);
        }
        private bool IsValid()
        {
            var time = DateTime.Now;

            return (time.Hour >= 8 && time.Minute >= 0) &&
                   (time.Hour < 22 );
        }
    }
}
