using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm1
{
    class Passenger
    {
        public int id;
        public int customerId;
        public int flightId;


        public Passenger(int i, int c, int f)
        {
            ID = i;
            CutomerId = c;
            FlightId = f;

        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int CutomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public int FlightId
        {
            get { return flightId; }
            set { flightId = value; }
        }

    }
}
