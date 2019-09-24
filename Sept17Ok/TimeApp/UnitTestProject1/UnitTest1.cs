using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodObj1()
        {
            Time2 myTime = new Time2();

            //NUnit
            Assert.AreEqual(0, myTime.Hour);
            Assert.AreEqual(0, myTime.Minute);
            Assert.AreEqual(0, myTime.Second);

        }

        [TestMethod]
        public void TestMethodObj2()
        {
            Time2 myTime = new Time2(2);

            //NUnit
            Assert.AreEqual(2, myTime.Hour);
            Assert.AreEqual(0, myTime.Minute);
            Assert.AreEqual(0, myTime.Second);

        }

        [TestMethod]
        public void TestMethodObj3()
        {
            Time2 myTime = new Time2(11, 30);

            //NUnit
            Assert.AreEqual(11, myTime.Hour);
            Assert.AreEqual(30, myTime.Minute);
            Assert.AreEqual(0, myTime.Second);

        }

        [TestMethod]
        public void TestMethodObj4()
        {
            Time2 myTime = new Time2(11, 12, 30);

            //NUnit
            Assert.AreEqual(11, myTime.Hour);
            Assert.AreEqual(12, myTime.Minute);
            Assert.AreEqual(30, myTime.Second);

        }

        [TestMethod]
        public void TestMethodObj5()
        {
            Time2 myTime = new Time2();
            Time2 myTime55 = new Time2(myTime);

            //NUnit
            Assert.AreEqual(0, myTime55.Hour);
            Assert.AreEqual(0, myTime55.Minute);
            Assert.AreEqual(0, myTime55.Second);

        }

        // public string ToUniversalString() =>
        //  $"{Hour:D2}:{Minute:D2}:{Second:D2}";
        [TestMethod]
        public void TestMethodToUniversalString()
        {
            Time2 myTime = new Time2(11, 4, 5);

            //NUnit
            string expResult = "11:04:05";
            Assert.AreEqual(expResult, myTime.ToUniversalString());

        }

        // public override string ToString() =>
        //     $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
        //     $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";

        [TestMethod]
        public void TestMethodToStringAM()
        {
            Time2 myTime = new Time2(11, 4, 5);

            //NUnit
            string expResult = "11:04:05 AM";
            Assert.AreEqual(expResult, myTime.ToString());

        }
    }
}
