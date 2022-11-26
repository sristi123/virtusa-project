// C# program to illustrate the concept of Constant Pattern
using System;

class GFG{

// Returns the name of the day of the week
public static string DayOfTheWeek(int day)
{
	
	// Switch expression
	return day switch
	{
		1 => "Sunday",
		2 => "Monday",
		3 => "Tuesday",
		4 => "Wednesday",
		5 => "Thursday",
		6 => "Friday",
		7 => "Saturday",
		_ => "Invalid week day"
	};
}

// Driver code
static public void Main()
{
	Console.WriteLine(DayOfTheWeek(5));
	Console.WriteLine(DayOfTheWeek(3));
}
}