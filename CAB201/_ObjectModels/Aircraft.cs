using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201._ObjectModels
{
    class Aircraft
    {
        protected int vehicleId { get; set; }
        protected string departureLocation { get; set; }
        protected string arrivalLocation { get; set; }
        protected string timeDeparting { get; set; }
        protected double flightRouteDistance { get; set; }
        protected int maxPassengers { get; set; }

        public Aircraft(int vehicleId, string departureLocation, string arrivalLocation, string timeDeparting, double flightRouteDistance)
        {
            this.vehicleId = vehicleId;
            this.departureLocation = departureLocation;
            this.arrivalLocation = arrivalLocation;
            this.timeDeparting = timeDeparting;
            this.flightRouteDistance = flightRouteDistance;
    }


    }

}
