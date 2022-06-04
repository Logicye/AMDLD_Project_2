using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201
{
    class Person
    {

        protected int id { get; set; }
        protected string name { get; set; }
        protected string email { get; set; }
        public Person( string name, string email)
        {
            this.id = 0; //set generated id, iterated or guid ?
            this.name = name;
            this.email = email;
        }
    }
}
