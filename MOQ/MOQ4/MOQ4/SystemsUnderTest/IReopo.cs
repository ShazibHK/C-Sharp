using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MOQ4.SystemsUnderTest
{
       public interface IRepo
    {
        event EventHandler FailedDatabaseRequest;
       // int TenantId { get; set; }
        Customer Find(int id);
        //IList<Customer> GetSome(Expression<Func<Customer, bool>> where);
        void AddRecord(Customer customer);
    }
}

