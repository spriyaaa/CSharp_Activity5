using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity5BL
{
    public class SeniorProjectManager : Employee
    {
        public double CarAllowance{get;set;}


        public override double CalculateSalary()
        {
            double salary= BasicSalary + CarAllowance;
            return salary;

        }

        public SeniorProjectManager()
        { CarAllowance = 6000.0; }

    }
}