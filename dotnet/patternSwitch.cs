// C# program to illustrate the concept of Type Pattern Switch
using static System.Console;

// Allows using WriteLine without Console. prefix
public class Person
{
	public string Name
	{
		get;
		set;
	}
}

class PatternSwitch{
	
static void PrintType(object obj)
{
	switch (obj)
	{
	case Person p:
		WriteLine("obj is a Person");
		WriteLine($"Name of the person: {p.Name}");
		break;

	case int i:
		WriteLine("obj is an int");
		WriteLine($"Value of the int: {i}");
		break;

	case double d:
		WriteLine("obj is a double");
		WriteLine($"Value of the double: {d}");
		break;

	default:
		WriteLine("obj is some other type");
		break;
	}

	WriteLine(); // New line
}

// Driver code
static public void Main()
{
	var person = new Person { Name = "Geek" };

	PrintType(42);
	PrintType(person);
	PrintType(3.14);
	PrintType("Hello");
}
}