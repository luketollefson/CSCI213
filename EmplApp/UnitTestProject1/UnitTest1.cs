using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmplApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestObj1()
        {
            BasePlusCommissionEmployee myEmp =
                new BasePlusCommissionEmployee("AAA", "BB", "123", 540.00M, 0.3M, 30000.0M);

            // NUnit
            Assert.AreEqual("AAA", myEmp.FirstName);
            Assert.AreEqual("BB", myEmp.LastName);
            Assert.AreEqual("123", myEmp.SocialSecurityNumber);
            Assert.AreEqual(540.00M, myEmp.GrossSales);
            Assert.AreEqual(0.3M, myEmp.CommissionRate);
            Assert.AreEqual(30000.0M, myEmp.Salary);
        }


        //public override string ToString() =>
        //    $"commission employee: {FirstName} {LastName}\n" +
        //    $"social security number: {SocialSecurityNumber}\n" +
        //    $"gross sales: {GrossSales:C}\n" +
        //    $"commission rate: {CommissionRate:F2}";
        [TestMethod]
        public void TestToString()
        {
            BasePlusCommissionEmployee myEmp =
                new BasePlusCommissionEmployee("AAA", "BB", "123", 540.00M, 0.3M, 30000.0M);

            string expResult = "commission employee: AAA BB\n"
                + "social security number: 123\n"
                + "gross sales: $540.00\n"
                + "commission rate: 0.30"
                + " Base Salary: $30,000.00";

            Assert.AreEqual(expResult, myEmp.ToString());
        }

        // Earnings()
        [TestMethod]
        public void Earnings()
        {
            BasePlusCommissionEmployee myEmp =
                new BasePlusCommissionEmployee("AAA", "BB", "123", 540.00M, 0.3M, 30000.0M);

            decimal expValue = 30162.0M;

            // NUnit
            Assert.AreEqual(expValue, myEmp.Earnings());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSale()
        {
            BasePlusCommissionEmployee myEmp =
                new BasePlusCommissionEmployee("AAA", "BB", "123", 540.00M, 0.3M, 30000.0M);

            myEmp.GrossSales = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRate()
        {
            BasePlusCommissionEmployee myEmp =
                new BasePlusCommissionEmployee("AAA", "BB", "123", 540.00M, 0.3M, 30000.0M);

            myEmp.CommissionRate = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSalary()
        {
            BasePlusCommissionEmployee myEmp =
                new BasePlusCommissionEmployee("AAA", "BB", "123", 540.00M, 0.3M, 30000.0M);

            myEmp.Salary = -1;
        }
    }
}
