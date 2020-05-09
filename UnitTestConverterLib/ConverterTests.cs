using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConverterLib;

namespace UnitTestConverterLib
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void TestConvert1()
        {
            IConverter converter = Factory.GetConverter();
            string actual = converter.Convert(453256378);
            string expected = "Fourty Five Crore,Thirty Two Lac,Fifty Six Thousand,Three Hundred And Seventy Eight";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TestConvert2()
        {
            IConverter converter = Factory.GetConverter();
            string actual = converter.Convert(139527767);
            string expected = "Thirteen Crore,Ninty Five Lac,Twenty Seven Thousand,Seven Hundred And Sixty Seven";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TestConvert3()
        {
            IConverter converter = Factory.GetConverter();
            string actual = converter.Convert(521392395);
            string expected = "Fifty Two Crore,Thirteen Lac,Ninty Two Thousand,Three Hundred And Ninty Five";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestConvert4()
        {
            IConverter converter = Factory.GetConverter();
            string actual = converter.Convert(192849212);
            string expected = "Nineteen Crore,Twenty Eight Lac,Fourty Nine Thousand,Two Hundred And Twelve";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TestConvert5()
        {
            IConverter converter = Factory.GetConverter();
            string actual = converter.Convert(127247737);
            string expected = "Twelve Crore,Seventy Two Lac,Fourty Seven Thousand,Seven Hundred And Thirty Seven";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TestConvert6()
        {
            IConverter converter = Factory.GetConverter();
            string actual = converter.Convert(163707203);
            string expected = "Sixteen Crore,Thirty Seven Lac,Seven Thousand,Two Hundred And Three";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TestConvert7()
        {
            IConverter converter = Factory.GetConverter();
            string actual = converter.Convert(807799285);
            string expected = "Eighty Crore,Seventy Seven Lac,Ninty Nine Thousand,Two Hundred And Eighty Five";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TestConvert8()
        {
            IConverter converter = Factory.GetConverter();
            string actual = converter.Convert(46310683);
            string expected = "Four Crore,Sixty Three Lac,Ten Thousand,Six Hundred And Eighty Three";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TestConvert9()
        {
            IConverter converter = Factory.GetConverter();
            string actual = converter.Convert(945197432);
            string expected = "Ninty Four Crore,Fifty One Lac,Ninty Seven Thousand,Four Hundred And Thirty Two";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TestConvert10()
        {
            IConverter converter = Factory.GetConverter();
            string actual = converter.Convert(878738802);
            string expected = "Eighty Seven Crore,Eighty Seven Lac,Thirty Eight Thousand,Eight Hundred And Two";
            Assert.AreEqual(expected, actual);
        }
    }
}

