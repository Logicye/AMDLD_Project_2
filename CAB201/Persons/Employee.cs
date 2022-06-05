using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAB201._ObjectModels;

namespace CAB201.Persons
{
    public class Employee : Person
    {
        protected string password { get; set; }
        public List<Employee> employees = new();
        public Employee(string name, string email, string password) : base(name, email)
        {
            this.password = password;
        }

        public void NewEmployee(string name, string email, string password)
        {
            employees.Add(new Employee(name, email, password));
            
        }
    }
}
