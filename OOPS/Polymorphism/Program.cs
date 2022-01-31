namespace Polymorphism
{
    class TestOverloading
    {
        public int add(int a,int b)
        {
            return a + b;
        }

        public float add(float a, float b)
        {
            return a + b;
        }
    }

    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread...");
        }
    }

    class Program
    {
        public static void Main(string[] Args) {
            int a = 1, b = 2;
            TestOverloading testOverloading = new TestOverloading();
            Console.WriteLine("Addition of "+a+"+"+b+"="+testOverloading.add(a,b));
            Console.WriteLine("\n******************\n");
            Dog d = new Dog();
            d.eat();
        }
    }
}