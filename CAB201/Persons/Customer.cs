using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201
{
    class Customer : Person
    {
        protected string address { get; set; }
        protected int number { get; set; }
        public Customer(string name, string email, string address, int number) : base(name, email)
        {
            this.address = address;
            this.number = number;
        }
    }
}
