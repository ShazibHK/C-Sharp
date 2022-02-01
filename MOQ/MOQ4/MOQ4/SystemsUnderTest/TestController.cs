using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ4.SystemsUnderTest
{
    public class TestController
    {
        private readonly IRepo _repo;
        private readonly ILogger _logger;

        public TestController(IRepo repo, ILogger logger = null)
        {
            _repo = repo;
            _logger = logger;
            _repo.FailedDatabaseRequest += _repo_FailedDatabaseRequest;
        }

        private void _repo_FailedDatabaseRequest(object sender, EventArgs e)
        {
            _logger.Error("An error occurred");
        }

      //  public int TenantId() => _repo.TenantId;
        //public void SetTenantId(int id) => _repo.TenantId = id;

        public Customer GetCustomer(int id)
        {
            try
            {
                _repo.AddRecord(new Customer());
                //var c = _repo.Find(id);
                return _repo.Find(id);

            }
            catch (Exception ex)
            {
                _logger.Error("Oops", ex);
                throw;
            }
        }

        public void SaveCustomer(Customer customer)
        {
            _repo.AddRecord(customer);
        }
    }
}