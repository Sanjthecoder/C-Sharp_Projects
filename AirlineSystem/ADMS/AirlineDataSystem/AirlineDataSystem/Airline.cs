using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm1
{
    class Airline
    {
        public int id;
        public string name;
        public string airplane;
        public int seatsAvailable;
        public string mealAvailable;


        public Airline(int i, string n, string a, int s, string m)
        {
            Id = i;
            Name = n;
            Airplane = a;
            SeatsAvailable = s;
            MealAvailable = m;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Airplane
        {
            get { return airplane; }
            set { airplane = value; }
        }
        public int SeatsAvailable
        {
            get { return seatsAvailable; }
            set { seatsAvailable = value; }
        }

        public string MealAvailable
        {
            get { return mealAvailable; }
            set { mealAvailable = value; }
        }




    }
}
