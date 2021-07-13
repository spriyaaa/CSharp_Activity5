using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity5BL
{
    public class Finance
    {
        public double GetCalculatedSalary(Employee obj)
        {
            if(obj.GetType()==  typeof(SystemsEngineer))
            {
                obj.Bonus = 5000;
            }

            else if (obj.GetType() == typeof(Manager))
            {
                obj.Bonus = 9000;
            }

            else if (obj.GetType() == typeof(SeniorProjectManager))
            {
                obj.Bonus = 15000;
            }

            else
            {
                obj.Bonus = 0;
            }

            return obj.Bonus + obj.CalculateSalary();
            /*double TotalSalary = propertyBonus + obj.basicSalary;
            return TotalSalary;*/


        }

        
    }
}