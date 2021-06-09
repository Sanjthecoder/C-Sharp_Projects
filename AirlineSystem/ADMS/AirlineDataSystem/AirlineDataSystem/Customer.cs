using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm1
{
    class Customer
    {
        public int id;
        public string name;
        public string address;
        public string email;
        public string phone;


        public Customer(int i, string n, string a, string e, string p)
        {
            ID = i;
            Name = n;
            Address = a;
            Email = e;
            Phone = p;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }


    }
}
