using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAB201._InterfaceModels;

namespace CAB201.Interfaces
{
    public class EmployeeLoginInterface : InterfaceModel
    {
        public enum loginOptions {registerNewEmployee = 1 ,loginAsExistingEmployee = 2,exit = 3};
        //public Dictionary<loginOptions, > options = new()
        //{
        //    //{ loginOptions.registerNewEmployee, RegisterNewEmployee()},
        //    //{ loginOptions.loginAsExistingEmployee, LoginAsExistingEmployee() },
        //    //{ loginOptions.exit, ExitProgram()}
        //};
        //EmployeeLoginInterface.options.Add()

        //public Dictionary<int, string> options = new()
        //{
        //    { 1,}
        //}


        public EmployeeLoginInterface(): base()
        {
            //options.Add(loginOptions.registerNewEmployee, RegisterNewEmployee());
            //options.Add(loginOptions.loginAsExistingEmployee, LoginAsExistingEmployee());
            //options.Add(loginOptions.exit, ExitProgram());

            //options[loginOptions.registerNewEmployee] = () => RegisterNewEmployee();

            //Add to caseOptions

        }

        //public void GenerateCaseOptions()
        //{
        //    for (int i = 0; i < loginOptions.Count(); i++)
        //    {

        //    }
        //    foreach (var option in loginOptions)
        //    {
        //        new CaseOptions( option.Key);
        //    }
        //}

        public void RegisterNewEmployee()
        {
            Console.WriteLine("Please Enter Empoyee's Email: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter Empoyee's Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Please Enter Empoyee's Email: ");
            string password = Console.ReadLine();
            //(name, email, password);
        }

        public void LoginAsExistingEmployee()
        {

        }

        public void ExitProgram()
        {

        }


    }
}
