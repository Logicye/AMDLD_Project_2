using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201._ObjectModels
{
    public class Person
    {
        protected int userId { get; set; }
        protected string name { get; set; }
        protected string email { get; set; }
        protected int numPersons { get; set; } = 0;
        public Person( string name, string email)
        {
            this.userId = New_User_Id(); //set generated id, iterated or guid ?
            this.name = name;
            this.email = email;
        }


        public int New_User_Id()
        {
            numPersons++;
            return numPersons;
        }

    }
}
