using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity5BL;

namespace Activity5UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sysobj = new SystemsEngineer("java");
            Finance fobj = new Finance();
            fobj.GetCalculatedSalary(sysobj);
            Employee mobj = new Manager();
            fobj.GetCalculatedSalary(mobj);
            Employee senobj = new SeniorProjectManager();
            fobj.GetCalculatedSalary(senobj);





        }
    }
}
