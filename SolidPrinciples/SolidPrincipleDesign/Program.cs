namespace SolidPrincipleDesign
{
    class DataAccess
    {
        public static void InsertData()
        {
            Console.WriteLine("Data inserted into database successfully");
        }
    }
    // Logger class is only responsible for logging related operations 
    class Logger
    {
        public static void WriteLog()
        {
            Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + " Log  Data insertion completed successfully");
        }
    }
    class Program
    {

        public static void Main(string[] Args)
        {
            DataAccess dataAccess = new DataAccess();
            Logger logger = new Logger();
        }
    }
}