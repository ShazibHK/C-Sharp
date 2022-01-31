using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BasicMaths;
namespace BasicMathsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            ArithmeticFunctions bm = new ArithmeticFunctions();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            ArithmeticFunctions bm = new ArithmeticFunctions();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            ArithmeticFunctions bm = new ArithmeticFunctions();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            ArithmeticFunctions bm = new ArithmeticFunctions();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
