using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MOQ4.SystemsUnderTest;
using System;
using System.Linq.Expressions;

namespace A_Tests
{
    [TestClass]
    public class Verification
    {
        [TestMethod]
        public void Should_Verify_Mock_Functions_Executed_Marked_Verifiable()
        {
            var id = 12;
            var name = "Fred Flinstone";
            var customer = new Customer { Id = id, Name = name };
            var mock = new Mock<IRepo>();
            Expression<Func<IRepo, Customer>> call= x => x.Find(id);
            mock.Setup(call).Returns(customer).Verifiable("Method not called");
            var controller = new TestController(mock.Object);
            var actual = controller.GetCustomer(id);
            Assert.AreSame(customer, actual);
            Assert.AreEqual(id, actual.Id);
            Assert.AreEqual(name, actual.Name);
            mock.Verify(call);
        }

        [TestMethod]
        public void Should_Verify_Times_Executed()
        {
            var id = 12;
            var name = "Fred Flinstone";
            var customer = new Customer { Id = id, Name = name };
            var mock = new Mock<IRepo>();
            Expression<Func<IRepo, Customer>> call = x => x.Find(id);
            mock.Setup(call).Returns(customer).Verifiable("Method not called");

            var controller = new TestController(mock.Object);

            var actual1 = controller.GetCustomer(id);
            var actual2 = controller.GetCustomer(id);
            mock.Verify(call, Times.Exactly(2));
        }


        [TestMethod]
        public void Should_Verify_All_Mock_Functions()
        {
            var id = 12;
            var name = "Fred Flinstone";
            var customer = new Customer { Id = id, Name = name };
            var mock = new Mock<IRepo>();
            mock.Setup(x => x.Find(id)).Returns(customer);

            Assert.ThrowsException<MockException>(() => mock.VerifyAll());
        }//cannot add functionality such as this method should be called 7 times,etc

        [TestMethod]
        public void Should_Not_Verify_Mock_Functions_Not_Verifiable()
        {
            var id = 12;
            var name = "Fred Flinstone";
            var customer = new Customer { Id = id, Name = name };
            var mock = new Mock<IRepo>();
            Expression<Func<IRepo, Customer>> call = x => x.Find(id);
            mock.Setup(call).Returns(customer);
            mock.Verify();
        }

        [TestMethod]
        public void Should_Verify_Mock_Functions_Not_Executed_Marked_Verifiable()
        {
            var id = 12;
            var name = "Fred Flinstone";
            var customer = new Customer { Id = id, Name = name };
            var mock = new Mock<IRepo>();
            Expression<Func<IRepo, Customer>> call = x => x.Find(id);
            var errorMessage = "Method not called";
            mock.Setup(call).Returns(customer).Verifiable(errorMessage);
            var ex = Assert.ThrowsException<MockException>(() => mock.Verify(call));
        }


    }
}