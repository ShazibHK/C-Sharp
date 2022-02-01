using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MOQ3;
using Moq;
namespace MoqUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockinfo = new Mock<IInfo>();
            mockinfo.SetupAllProperties();
            mockinfo.Setup(m => m.name).Returns("Shazib");
            mockinfo.SetupSequence(p => p.legs).Returns("4").Returns("2");

            Action act = () =>
            {
                var sut = new Animal(mockinfo.Object);
                Assert.AreEqual("4", "4");
                Assert.AreEqual("2", sut.Legs());
                Assert.AreEqual("Shazibl", sut.name());
                Console.WriteLine($"Health{ sut.Health()}");
            };
        }
    }
}
