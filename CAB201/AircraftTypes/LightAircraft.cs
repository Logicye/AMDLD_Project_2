using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAB201._ObjectModels;

namespace CAB201.AircraftTypes
{
    class Light_Aircraft : Aircraft
    {
        public Light_Aircraft(int vehicleId, string departureLocation, string arrivalLocation, string timeDeparting, double flightRouteDistance) : base(vehicleId, departureLocation, arrivalLocation, timeDeparting, flightRouteDistance)
        {
            maxPassengers = 6;
        }
    }
}
