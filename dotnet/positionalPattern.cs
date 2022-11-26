// C# program to illustrate the concept of Positional Pattern
using System;

class positionalPattern{
	
// Displays the location of a point
// by accepting its x and y coordinates
public static void LocatePoint(int x, int y)
{
	Console.WriteLine($"Point ({x}, {y}):");
	
	// Using switch statement
	// Note the double parantheses
	switch ((x, y))
	{
		case (0, 0):
			Console.WriteLine("Point at origin");
			break;
		case (0, _): // _ will match all values for y
			Console.WriteLine("Point on Y axis");
			break;
		case (_, 0):
			Console.WriteLine("Point on X axis");
			break;
		default:
			Console.WriteLine("Point elsewhere");
			break;
	}
}

// Driver code
static public void Main()
{
	LocatePoint(10, 20);
	LocatePoint(10, 0);
	LocatePoint(0, 20);
	LocatePoint(0, 0);
}
}