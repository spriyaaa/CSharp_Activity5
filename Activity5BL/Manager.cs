using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity5BL
{
    public class Manager : Employee
    {

        public double PhoneAllowance { get; set; }

        public override double CalculateSalary()
        {
            double salary = BasicSalary + PhoneAllowance;
            return salary;

        }

        public Manager()
        { PhoneAllowance = 4000.0; }
    }
}