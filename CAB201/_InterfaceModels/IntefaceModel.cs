using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201._InterfaceModels
{
    public class InterfaceModel
    {
        private List<InterfaceModel> interfaces;
        protected int interfaceId { get; set; }

        public InterfaceModel()
        {
            this.interfaceId = NewInterfaceId();
        }

        public int NewInterfaceId()
        {
            int num = interfaces.Count();
            return num;
        }


        public int Count()
        {
            int instances = 0;
            foreach (InterfaceModel intface in interfaces)
            {
                instances++;
            }

            return instances;
        }





        internal class CaseOptions
        {

            protected int caseId { get; set; }
            protected int caseNumber { get; set; }
            protected string caseMethodName { get; set; }

            public List<CaseOptions> cases = new List<CaseOptions>();
            public CaseOptions(string caseMethodName)
            {
                this.caseId = NewCaseId();
                this.caseMethodName = caseMethodName;

            }

            public void PrintOptions()
            {
                foreach (var caseOption in cases)
                {
                    Console.WriteLine("  " + caseOption.caseId.ToString() + ") " + caseOption.caseMethodName);
                }
            }

            public void Menu()
            {
                PrintOptions();

            }


            //potentially redundent
            public int Count()
            {
                return cases.Count();
            }

            public int NewCaseId()
            {
                int caseNumber = cases.Count();
                return caseNumber;
            }

            public static int TakeOption(CaseOptions cases)
            {
                int input = 0;
                while (!(input == cases.Count()))
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                return input;
            }
        }

    }
}
