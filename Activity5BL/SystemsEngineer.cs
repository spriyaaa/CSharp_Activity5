using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity5BL
{
    public class SystemsEngineer: Employee
    {


        public double SpecialistAllowance { get; set; }
        public string Specialization { get; set; }


        public override  double CalculateSalary()
        {
            if(Specialization == "java" || Specialization == "sql" || Specialization == "c#")
            {
                SpecialistAllowance = 3000.0;

            }

            else
            {
                SpecialistAllowance = 0.0;

            }

            double salary = BasicSalary + SpecialistAllowance;
            return salary;

        }

        public SystemsEngineer(string specialization): base()
        {


            try
            {
                Console.WriteLine(specialization);
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine("Please check the value.");
                Console.WriteLine(err.Message);
            }

            finally
            {
                Console.WriteLine("Continuing with other procedures..");
                Specialization = specialization;

            }
            

        }

        public SystemsEngineer()
        { }




    

    }
}