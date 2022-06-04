using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201
{
    class Employee : Person
    {
        protected string password { get; set; }
        public Employee(string name, string email, string password) : base(name, email)
        {
            this.password = password;
        }
    }
}
