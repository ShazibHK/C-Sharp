namespace Abstraction
{
    class Program
    {
        public static void Main(string[] Args)
        {
            RegularEmployee regularEmployee = new RegularEmployee()
            {
                ID = 1,
                FirstName = "Shazib",
                LastName = "Hassan",
                AnnualSalary = 800000,
            };
            Console.WriteLine(regularEmployee.GetFullName());
            Console.WriteLine(regularEmployee.GetMonthlySalary());

            ContractEmployee contractEmployee = new ContractEmployee()
            {
                ID = 1,
                FirstName = "Shawn",
                LastName = "Dsouza",
                HourlyPay = 820,
                TotalHours = 80
            };
            Console.WriteLine("************************************");
            Console.WriteLine(contractEmployee.GetFullName());
            Console.WriteLine(contractEmployee.GetMonthlySalary());
        }
    }
}