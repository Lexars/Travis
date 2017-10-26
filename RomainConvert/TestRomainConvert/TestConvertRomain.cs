using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryRomainConvert;
using System;

namespace TestRomainConvert
{
    [TestClass]
    public class TestConvertRomain
    {
        [TestMethod]
        public void TestMethodI()
        {
            //arrange
            var romainConvert = new ConverRomain();
            //act
             var result = romainConvert.Convert("1");
            //assert
            Assert.AreEqual("I", result);
        }
        [TestMethod]
        public void TestMethodV()
        {
            //arrange
            var romainConvert = new ConverRomain();
            //act
            var result = romainConvert.Convert("5");
            //assert
            Assert.AreEqual("V", result);
        }
        [TestMethod]
        public void TestMethodM()
        {
            //arrange
            var romainConvert = new ConverRomain();
            //act
            var result = romainConvert.Convert("1000");
            //assert
            Assert.AreEqual("M", result);
        }
        [TestMethod]
        public void TestMethodX()
        {
            //arrange
            var romainConvert = new ConverRomain();
            //act
            var result = romainConvert.Convert("10");
            //assert
            Assert.AreEqual("X", result);
        }
        [TestMethod]
        public void TestMethodL()
        {
            //arrange
            var romainConvert = new ConverRomain();
            //act
            var result = romainConvert.Convert("50");
            //assert
            Assert.AreEqual("L", result);
        }
        [TestMethod]
        public void TestMethodC()
        {
            //arrange
            var romainConvert = new ConverRomain();
            //act
            var result = romainConvert.Convert("100");
            //assert
            Assert.AreEqual("C", result);
        }
        [TestMethod]
        public void TestMethodD()
        {
            //arrange
            var romainConvert = new ConverRomain();
            //act
            var result = romainConvert.Convert("500");
            //assert
            Assert.AreEqual("D", result);
        }
    }
}
