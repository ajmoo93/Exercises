using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
   public class Employeeregistry
    {
        private void DisplayEmployeeMethod(ref List<Employee> NewEmployee, ref List<Employee> TempList, ref int NumberOfEmployees, ref string TempEmployeeName, ref string TempWage, ref string TempStrength)
        {
            Console.WriteLine("----------------------------");
            foreach (Employee element in NewEmployee)
            {
                Console.WriteLine(element.ToString());
                Console.WriteLine("----------------- ");
            }
        }


        private void DisplayEmployeeregistry(ref List<Employee> NewEmployee, ref List<Employee> TempList, ref int NumberOfEmployees, ref string TempEmployeeName, ref string TempWage, ref string TempStrength)
        {
            int EmployeeChoice;
            Console.Write("Which employee would you like to remove:");
            EmployeeChoice = int.Parse(Console.ReadLine());

            NewEmployee.RemoveAll(RemoveNewEmployee => RemoveNewEmployee.mEmployeeNumber == EmployeeChoice);

            TempList.AddRange(NewEmployee);

            NewEmployee.Clear();

            TempEmployeeNumber = 0;

            foreach (Employee element2 in TempList)
            {
                TempEmployeeNumber++;
                element2.mEmployeeNumber = TempEmployeeNumber;
                NewEmployee.Add(element2);
            }
        }
    }
}
        ////public List<Employee> Anställda = new List<Employee>();


        ////i denna klass skall du kunna lägga till och ta bort anställda.

        ////public Employeeregistry()
        ////{

        ////    Anställda = new List<Employee>();
        ////    Anställda = new employee();
        ////}
        ////public void AddToTheList(Employee information, string name, string lname, string ssn, string wage)

        ////{
        ////    Anställda.Add(information);

        ////}



  