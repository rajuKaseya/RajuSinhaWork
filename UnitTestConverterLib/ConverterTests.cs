using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestConverterLib
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void TestConvert()
        {
            string Actual = "";
            string expected = ",";
            Assert.AreEqual(expected,Actual);
        }
    }
}
