using System;
using CAB201.Persons;

namespace CAB201
{
    class MainSolution
    {
        static void Main(string[] args)
        {
            bool showmenu = true;
            while (showmenu)
            {
                showmenu = MainMenu();
            }



        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("\t1) Register as new Employee");
            Console.WriteLine("\t2) Login as existing Employee");
            Console.WriteLine("\t3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    RegisterNewEmployee();
                    return false;
                case "2":
                    LoginAsEmployee();
                    return false;
                case "3":
                    ExitProgram();
                    return false;
                default:
                    Console.WriteLine("Please Enter Valid Option");
                    return true;
            }
        }

        public void RegisterNewEmployee()
        {
            Console.Clear();
            Console.WriteLine("Please enter user Information");
            Console.Write("\tName: ");
            string name = Console.ReadLine();
            Console.Write("\tEmail: ");
            string email = Console.ReadLine();
            Console.Write("\tPassword: ");
            string password = "";
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                {
                    password += keyInfo.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        password = password.Substring(0, (password.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            while (keyInfo.Key != ConsoleKey.Enter);
            Employee[name] = new Employee(name, email, password);
            Employee.employees.Add(name);
            MainMenu();
        }

        public static void LoginAsEmployee()
        {
            Console.Clear();
            Console.WriteLine("Please enter user Information");
            Console.Write("\tEmail: ");
            string email = Console.ReadLine();
            Console.Write("\tPassword: ");
            string password = "";
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                {
                    password += keyInfo.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        password = password.Substring(0, (password.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            while (keyInfo.Key != ConsoleKey.Enter);

            if (email == Employee.)
        }

        public static void ExitProgram()
        {
            Environment.Exit(0);
        }


    }
}
