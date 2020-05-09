using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConverterLib;

namespace UnitTestConverterLib
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void TestConvert()
        {
            IConverter converter = Factory.GetConverter();
            string actual = converter.Convert(453256378);
            string expected = "Fourty Five Crore, Thirty Two lac, Fifty Six Thousand, Three hundred and Seventy Eight";
            Assert.AreEqual(expected, actual);
        }
    }
}

