using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebApplication8;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DemoTest obj = new DemoTest();
            Assert.AreEqual("Ranjith", obj.fname);
            Assert.AreEqual("Prasanna", obj.lname);
        }
    }
}
