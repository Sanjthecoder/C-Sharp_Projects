using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm1
{
    class Flights
    {
        public int id;
        public int airlineId;
        public string departureCity;
        public string destinationCity;
        public string depatureDate;
        public double flightTime;



        public Flights(int i, int air, string depc, string desc, string depd, double f)
        {
            ID = i;
            AirlineId = air;
            DepartureCity = depc;
            DestinationCity = desc;
            DepatureDate = depd;
            FlightTime = f;

        }

        public int ID
        {
            get { return id; }
            set { id = value; }

        }

        public int AirlineId
        {
            get { return airlineId; }
            set { airlineId = value; }

        }

        public string DepartureCity
        {
            get { return departureCity; }
            set { departureCity = value; }

        }

        public string DestinationCity
        {
            get { return destinationCity; }
            set { destinationCity = value; }

        }

        public string DepatureDate
        {
            get { return depatureDate; }
            set { depatureDate = value; }

        }

        public double FlightTime
        {
            get { return flightTime; }
            set { flightTime = value; }

        }

    }
}
