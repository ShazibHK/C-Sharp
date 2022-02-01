using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;

namespace MOQ
{
    public class Employee
    {
        public virtual DateTime GetDateofJoining(int id)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Mock<Employee>();
            employee.Setup(x => x.GetDateofJoining(It.IsAny<int>())).Returns((int x) => DateTime.Now);

            Console.WriteLine(employee.Object.GetDateofJoining(1));
            Console.ReadLine();
        }
    }
}
