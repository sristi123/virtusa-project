// C# program to illustrate the usage
// of File.SetCreationTime(String, DateTime) method

// Using System and System.IO namespaces
using System;
using System.IO;

class CreationTime {
	static void Main()
	{
		
		DateTime D1 = new DateTime(2017, 12, 25, 2, 6, 8);
		File.SetCreationTime("file.txt", D1);
		DateTime D2 = File.GetCreationTime("file.txt");
		Console.WriteLine("The File Creation Time is : " + D2.ToString());
	}
}
