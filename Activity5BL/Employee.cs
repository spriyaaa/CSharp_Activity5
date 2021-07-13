using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity5BL
{
    public class Employee
    {
        private double basicSalary;
        private double bonus;
        private int employeeId;


        public double BasicSalary
        {
            get
            {
                return basicSalary;
            }

            set
            {
                basicSalary = value;
            }
        }
        public double Bonus {
            get
            {
                return bonus;
            }

            set
            {
                bonus = value;
            }
            
        }
        public int EmployeeId {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
            
        }

        public virtual double CalculateSalary()
        {
            return BasicSalary;

        }

        public Employee()
        {  BasicSalary = 10000.0; }



    }
}