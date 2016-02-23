using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{

    public class Employee
    {
        private int EmployeeNumber;
        private string EmployeeName;
        private string EmployeeWage;
        private int Strength;

        //public Employee()
        //{
        //    EmployeeNumber = 1;
        //    EmployeeName = "Göran";
        //    EmployeeWage = "32525";
        //    Strength = 2000;
        //}

        public Employee(int newEmployeeNUmber, string newEmployeeName, string newEmployeeWage, int newStrength)
        {
            this.EmployeeNumber = newEmployeeNUmber;
            this.EmployeeName = newEmployeeName;
            this.EmployeeWage = newEmployeeWage;
            this.Strength = newStrength;
        }
        public int mEmployeeNumber
        {
            get
            {
                return EmployeeNumber;

            }
            set
            {
                EmployeeNumber = value;
            }
        }

        public string mEmployeeName
        {
            get
            {
                return EmployeeName;

            }
            set
            {
                EmployeeName = value;
            }
        }
        public string mEmployeeWage
        {
            get
            {
                return EmployeeWage;
            }
            set
            {
                EmployeeWage = value;
            }
        }

        
            public int mStength
        {
            get
            {
                return Strength;

            }
            set
            {
                Strength = value;
            }
        }

        public int mStrength { get; internal set; }

        public override string ToString()
        {
            return "Employee #:" + EmployeeNumber + "\n" +
                   "Employee Name: " + EmployeeName + "\n" +
                   "Employee Wage: " + EmployeeWage + "\n" +
                  "Employee strength: " + Strength;
        }

        public int CompareTo(Employee other)
        {
            if (this.EmployeeNumber <= other.EmployeeNumber)
            {
                return this.EmployeeNumber.CompareTo(other.EmployeeNumber);
            }
            return other.EmployeeNumber.CompareTo(this.EmployeeNumber);
        }
    }
}
//        //    //private string FName = string.Empty;
//        //    //private string LName = string.Empty;
//        //    //private string Ssn = string.Empty;
//        //    //private int Wage = 0;

//        //string fname = "Emil";
//        //string lname = "Lindgren";
//        //string ssn = " 1993-10-44";
//        //string wage = " 323232323";

//        string fname;
//        string lname;
//        string ssn;
//        string wage;

//        //public string fname { get { return this.FName; } }
//        //public string lname { get { return LName; } }
//        //public string ssn { get { return Ssn; } }
//        //public int wage { get { return Wage; } }


//        public Employee()
//        {

//        }
//        public Employee(string fname, string lname, string ssn, string wage)

//        {

//    }
//        public string Fname { get { return fname; } set { } }
//        public string Lname { get { return lname; } set { } }
//        public string Ssn { get { return ssn; } set { } }
//        public string Wage { get { return wage; } set { } }
//        public string fullname { get { return Fname + Lname; } set { } }


//    }
//}



//    this.FName = FName;
//    this.LName = LName;
//    this.Ssn = Ssn;
//    this.Wage = Wage;
//}




