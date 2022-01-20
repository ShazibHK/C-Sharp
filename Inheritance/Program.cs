class A
{

    public string key = "FirstClass01";
    public void display()
    {
        Console.WriteLine("I am the parent class");
        

    }
}
class B:A
{
    public void display()
    {
        Console.WriteLine("\nI am the Child class");
        Console.WriteLine("Displaying key of parent class that is been inheritted key->" +key);

    }
}

class C:B
{
    string key = "ABC";
    public void display()
    {
        Console.WriteLine("\nI am the Grand Child class");
        Console.WriteLine("Displaying key of parent class that is been inheritted key->" + base.key);

    }
}
class D : A
{
    public void display()
    {
        Console.WriteLine("\nI am Sibling of class A achieved through hierarchical");

    }
}

class Program
{
    public static void Main(String[] Args) { 
        A a = new A();
        B b = new B();
        C c = new C();
        a.display();
        b.display();
        c.display();
    }
}