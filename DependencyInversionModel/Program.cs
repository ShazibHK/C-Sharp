namespace DIM
{
    public class CustomerDataAccess
    {
        public CustomerDataAccess() { }

        public String GetCustomerNameDataAccess()
        {
            return "Customer Name";
        }
    }

    public class CustomerBL
    {
        public CustomerBL() { }
        public void GetCustomerNameBL()
        {
            CustomerDataAccess customerDataAccess = new CustomerDataAccess();
            customerDataAccess.GetCustomerNameDataAccess();
        }
    }
}