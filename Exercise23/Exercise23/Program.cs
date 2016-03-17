using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate? c1 = null;
            Coordinate? c2 = new Coordinate { X = 5, Y = 5 };
            Coordinate? c3 = new Coordinate { X = 25, Y = 25 };

            Coordinate c4 = c1.Value;
            c4.X = 5;
            c4.Y = 5;


            //c1 = new Coordinate(X = 20, Y = 20)

            Triangle mTriangle;
            if (c1.HasValue && c2.HasValue && c3.HasValue)
            {
                mTriangle = new Triangle(c1.Value, c2.Value, c3.Value);
            }
        
            var checkEmployee = new Checkbox { Description = "Employee" };
            if (checkEmployee.Checked.HasValue)
            {
                var isChecked = checkEmployee.Checked.HasValue;
                if (isChecked)
                    Console.WriteLine("Employee is checked");
                else
                    Console.WriteLine(" Employee is not checked");
            }
            else
            {
                Console.WriteLine("Employees value is not checked");
            }
        }
    }
}
