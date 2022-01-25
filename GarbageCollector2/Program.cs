using System;
namespace GCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 1000000; i++)
            {
                MyClass obj = new MyClass();
                obj.Dispose();
            }
            Console.Read();
        }
    }

    public class MyClass : IDisposable
    {
        ~MyClass()
        {
        }
        public void Dispose()
        {
            //Unmanaged code clean up
            GC.SuppressFinalize(true);
        }
    }
}