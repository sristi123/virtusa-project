// // C# program to illustrate the concept of Property Pattern
// using System;

// class GFG{

// public static void DescribeStringLength(string str)
// {
	
// 	// Constant pattern, discussed further
// 	if (str is null)
// 	{
// 		Console.WriteLine("Null string");
// 	}

// 	if (str is { Length: 0 })
// 	{
// 		Console.WriteLine("Empty string");
// 		return;
// 	}

// 	if (str is { Length: 1 })
// 	{
// 		Console.WriteLine("String of length 1");
// 		return;
// 	}

// 	Console.WriteLine("Length greater than 1");
// 	return;
// }

// // Driver code
// static public void Main()
// {
// 	DescribeStringLength("Hello!");
// 	Console.WriteLine();
// 	DescribeStringLength("");
// 	Console.WriteLine();
// 	DescribeStringLength("X");
// 	Console.WriteLine();
// }
// }