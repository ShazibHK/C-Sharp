using System;
public class Encap
{
	private String studentName;
	private int studentAge;
	public String Name
	{
		get
		{
			return studentName;
		}
		set
		{
			studentName = value;
		}
	}
	public int Age
	{
		get
		{
			return studentAge;
		}

		set
		{
			studentAge = value;
		}
	}
}

class Program
{
	static public void Main()
	{

		Encap obj = new Encap();
		obj.Name = "Shazib";
		obj.Age = 24;
	
		Console.WriteLine("Name: " + obj.Name);
		Console.WriteLine("Age: " + obj.Age);
	}
}
