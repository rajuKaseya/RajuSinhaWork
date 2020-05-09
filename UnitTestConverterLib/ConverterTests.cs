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
            string expected = "Fourty Five Crore,Thirty Two Lac,Fifty Six Thousand,Three Hundred And Seventy Eight";
            Assert.AreEqual(expected, actual);
        }
    }
}

