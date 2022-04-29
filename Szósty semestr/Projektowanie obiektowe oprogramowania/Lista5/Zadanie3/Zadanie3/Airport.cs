using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public class Plane { }
    interface IAirport
    {
        Plane AcquirePlane();
        void RelasePlane(Plane plane);
    }
    public class Airport : IAirport
    {
        private int _capacity;
        private List<Plane> ready = new List<Plane>();
        private List<Plane> issued = new List<Plane>();
        public Airport(int capacity)
        {
            if(capacity <= 0)
            {
                throw new ArgumentException();
            }
            this._capacity = capacity;
        }
        
        public Plane AcquirePlane()
        {
            if(issued.Count() == this._capacity)
            {
                throw new ArgumentException();
            }

            if(ready.Count() == 0)
            {
                Plane newplane = new Plane();
                ready.Add(newplane);
            }

            var plane = ready[0];

            ready.Remove(plane);
            issued.Add(plane);

            return plane;
        }
        public void RelasePlane(Plane plane)
        {
            if (!issued.Contains(plane))
                throw new ArgumentException();

            issued.Remove(plane);
            ready.Add(plane);
        }
    }
}
