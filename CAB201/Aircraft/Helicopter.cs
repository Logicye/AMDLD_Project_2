using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201
{
    class Helicopter : Aircraft
    {
        public Helicopter(int vehicleId, string departureLocation, string arrivalLocation, string timeDeparting, double flightRouteDistance) : base(vehicleId, departureLocation, arrivalLocation, timeDeparting, flightRouteDistance)
        {
            maxPassengers = 2;
        }
    }
}
