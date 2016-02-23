using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> NewEmployee = new List<Employee>(); // Huvud Listan av Employee
            List<Employee> TempList = new List<Employee>();   // En lista med tillfällig information

            int NumberOfEmployees = 0;
            int TempEmployeeNumber = 0;
            string TempEmployeeName = "";
            string TempWage = "";
            int TempStrength = 0;

            DisplayTitle();
            MainProgram(ref NewEmployee, ref TempList, ref NumberOfEmployees, ref NumberOfEmployees, ref TempEmployeeNumber, ref TempEmployeeName, ref TempWage, ref TempStrength);

        }

        private static void MainProgram(ref List<Employee> newEmployee, ref List<Employee> TempList, ref int numberOfEmployees1, ref int numberOfEmployees2, ref int TempEmployeeNumber, ref string TempEmployeeName, ref string TempWage, ref int tempStrength);
        
       

        private void DisplayTitle()
        {
            Console.WriteLine(" Employee List");
            Console.WriteLine("-----------------------------");

        }
        private void PauseScreen()
        {
            Console.ReadKey();
        }

        private void ClearScreen()
        {
            Console.Clear();
        }

        private void MainProgram(ref List<Employee> NewEmployee, ref List<Employee> TempList, ref int NumberOfEmployees, ref int TempEmployeeNumber, ref string TempEmployeeName, ref string TempWage, ref int TempStrength)
        {
            Console.Write("How many Employees do you want to add:");
            NumberOfEmployees = int.Parse(Console.ReadLine());

            for (int count = 0; count < NumberOfEmployees; count++) ;
            {
                Employee myEmployee = new Employee(TempEmployeeNumber, TempEmployeeName, TempWage, TempStrength);

                TempEmployeeNumber++;
                myEmployee.mEmployeeNumber = TempEmployeeNumber;

                Console.Write("Name of Employee:");
                TempEmployeeName = Console.ReadLine();
                myEmployee.mEmployeeName = TempEmployeeName;

                Console.Write("Wage:");
                TempWage = Console.ReadLine();
                myEmployee.mEmployeeWage = TempWage;

                Console.Write("Total Strength:");
                TempStrength = int.Parse(Console.ReadLine());
                myEmployee.mStrength = TempStrength;

                NewEmployee.Add(myEmployee);
            }

            ClearScreen();
            DisplayTitle();
            DisplayEmployeeMethod(ref NewEmployee, ref TempList);  // Metoden kallar

            RemoveMethod(ref NewEmployee, ref TempList, ref NumberOfEmployees, ref TempEmployeeNumber, ref TempEmployeeName, ref TempWage, ref TempStrength);
            DisplayEmployeeMethod(ref NewEmployee, ref TempList);
            PauseScreen();
        }
    }
}

//private void DisplayEmployeeMethod(ref List<Employee> NewEmployee, ref List<Employee> TempList, ref int NumberOfEmployees, ref string TempEmployeeName, ref string TempWage, ref string TempStrength)
//{
//Console.WriteLine("----------------------------");
//    foreach(Employee element in NewEmployee)
//    {
//    Console.WriteLine(element.ToString());
//    Console.WriteLine("----------------- ");
//    }
//    }


//    private void DisplayEmployeeregistry(ref List<Employee> NewEmployee, ref List<Employee> TempList, ref int NumberOfEmployees, ref string TempEmployeeName, ref string TempWage, ref string TempStrength)
//{
//int EmployeeChoice; 
//Console.Write("Which employee would you like to remove:");
//    EmployeeChoice  = int.Parse(Console.ReadLine());

//NewEmployee.RemoveAll(RemoveNewEmployee => RemoveNewEmployee.mEmployeeNumber == EmployeeChoice);

//            TempList.AddRange(NewEmployee);

//            NewEmployee.Clear();

//            TempEmployeeNumber = 0;

//            foreach (Employee element2 in TempList)
//            {
//                TempEmployeeNumber++;
//                element2.mEmployeeNumber = TempEmployeeNumber;
//                NewEmployee.Add(element2);
//            }
//    }
//    }
//    }


//            Console.WriteLine("------------------");
//            Console.WriteLine("[1]Add new Person");
//            Console.WriteLine("[2]Remove a Person");
//            Console.WriteLine("[3] Check the registry");
//            Console.WriteLine("[4]Exit");
//            int val = int.Parse(Console.ReadLine());
//            Console.Clear();

//            switch (val)
//            {
//                case 1:

//                    Console.WriteLine("Add a new Employee\n--------------------");
//                    Console.WriteLine("Firstname");
//                    string fname = Console.ReadLine();

//                    Console.WriteLine("Lastname");
//                    string lname = Console.ReadLine();

//                    Console.WriteLine("Security number");
//                    string ssn = Console.ReadLine();

//                    Console.WriteLine("wage");
//                    string wage = Console.ReadLine();
//                    Employee Employee = new Employee(fname, lname, ssn, wage);
//                    Logger Listan = new Logger();

//                    Console.WriteLine("----------");
//                    Console.WriteLine("You added this person");
//                    Listan.Log(fname);
//                    Listan.Log(lname);
//                    Listan.Log(ssn);
//                    Listan.Log(wage);

//                    //foreach (var item in Listan.LogPosts)
//                    //{
//                    //    Console.WriteLine(item);

//                    //}

//                    break;

//                case 2:

//                    Console.WriteLine(" Remove Employee by tying the ssn:");
//                    //item.RemoveAll(item => item == null);
//                    break;

//                case 3:
//                    Console.WriteLine("Registry");
//                    //Console.WriteLine("Firstnamn", Lnamn ",);
//                    //Employee Employee = new Employee(fname, lnamn, ssn, wage);
//                    //Logger Listan = new Logger();


//                    //foreach (Employee person in employeeklass)
//                    //{
//                    //    if (person != null)
//                    //    {
//                    //        person.Print(); // method that prints out information of each object of the employee class
//                    //    }
//                    //}
//                    break;

//                case 4:

//                    Console.WriteLine("Exit");
//                    Console.ReadLine();
//                    break;
//            }
//        }
//    }
//}
