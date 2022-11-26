// C# program to illustrate the usage
// of File.SetLastWriteTime() method

// Using System and System.IO namespaces
using System;
using System.IO;

class WriteTime {
	public static void Main()
	{
	
		string myfile = @"file.txt";

		
		File.SetLastWriteTime(myfile, new DateTime(2020,
										5, 4, 4, 5, 7));

		
		DateTime dt = File.GetLastWriteTime(myfile);
		Console.WriteLine("The last written date and "+
					"time for this file was {0}.", dt);
	}
}
