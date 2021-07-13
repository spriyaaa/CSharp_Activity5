using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity5BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5BL.Tests
{
    [TestClass()]
    public class FinanceTests
    {
        [TestMethod()]
        public void GetCalculatedSalaryTest1()
        {
            Employee mobj = new Manager();
            Finance fobj = new Finance();
            double actual= fobj.GetCalculatedSalary(mobj);
            double expected = 23000.0;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetCalculatedSalaryTest2()
        {
            Employee senobj = new SeniorProjectManager();
            Finance fobj = new Finance();
            double actual = fobj.GetCalculatedSalary(senobj);
            double expected = 31000.0;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetCalculatedSalaryTest3()
        {
            Employee sysobj = new SystemsEngineer("java");
            Finance fobj = new Finance();
            double actual = fobj.GetCalculatedSalary(sysobj);
            double expected = 18000.0;
            Assert.AreEqual(expected, actual);

        }

 
    }
}