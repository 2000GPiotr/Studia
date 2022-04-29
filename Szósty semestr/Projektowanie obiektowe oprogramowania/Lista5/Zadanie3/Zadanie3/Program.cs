using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProtectProxyAirport protectedAirport = new ProtectProxyAirport(2);
            var plane1 = protectedAirport.AcquirePlane();
            var plane2 = protectedAirport.AcquirePlane();
            protectedAirport.RelasePlane(plane2);

            LogProxyAirport logAirport = new LogProxyAirport(2);
            var plane3 = logAirport.AcquirePlane();
            var plane4 = logAirport.AcquirePlane();
            logAirport.RelasePlane(plane3);
        }
    }
}
