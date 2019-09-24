using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InvoiceApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodObj1()
        {
            Invoice MyInv = new Invoice(111, "AAA", 6, 356);

            // Unit test with NUnit
            Assert.AreEqual(111, MyInv.PartNumber);
            Assert.AreEqual("AAA", MyInv.PartDescription);
            Assert.AreEqual(6, MyInv.Quantity);
            Assert.AreEqual(356, MyInv.Price);

        }

        [TestMethod]
        public void TestMethodQty()
        {
            Invoice MyInv = new Invoice(111, "AAA", 6, 356);
            MyInv.Quantity = -1;

            int expVal = 6;

            // NUnit
            Assert.AreEqual(expVal, MyInv.Quantity);
        }

        [TestMethod]
        public void TestMethodPrice()
        {
            Invoice MyInv = new Invoice(111, "AAA", 6, 356);
            MyInv.Quantity = -1;

            int expVal = 356;

            // NUnit
            Assert.AreEqual(expVal, MyInv.Price);
        }

        // return string.Format("{0,-5} {1,-20} {2,-5} {3,6:C}",
        //  PartNumber, PartDescription, Quantity, Price);
        [TestMethod]
        public void TestMethodToString()
        {
            Invoice MyInv = new Invoice(111, "AAA", 1, 356);

            string expVal = "111   " + "AAA                  " + "1     " + "$356.00";

            // NUnit
            Assert.AreEqual(expVal, MyInv.ToString());
        }
    }

}
