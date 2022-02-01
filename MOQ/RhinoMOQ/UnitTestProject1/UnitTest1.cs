using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System;
using RhinoMOQ;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RhinoMocksDemoTest()
        {
            MockRepository mocks = new MockRepository();
            var mock = mocks.DynamicMock<ISomethingUseful>();
            SetupResult.For(mock.CalculateSomething(0)).IgnoreArguments().Return(1);
            mocks.ReplayAll();

            var myClass = new MyClass(mock);
            Assert.AreEqual(2, myClass.MethodUnderTest(123));
        }

    }
}
