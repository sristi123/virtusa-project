// Program to check if a number is positive,
// negative or zero using relational patterns
// using a switch statement
using System;

class patterMatch{
	
public static string GetNumberSign(int number)
{
	switch (number)
	{
		case < 0:
			return "Negative";
		case 0:
			return "Zero";
		case >= 1:
			return "Positive";
	}
}

// Driver code
static public void Main()
{
	int n1 = 0;
	int n2 = -31;
	int n3 = 18;
	
	Console.WriteLine(GetNumberSign(n1));
	Console.WriteLine(GetNumberSign(n2));
	Console.WriteLine(GetNumberSign(n3));
}
}