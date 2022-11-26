// C# Program to display the date
// and time of access of a file
using System;
using System.IO;

class TimeEx{
	
static void Main()
{
	
	
	FileInfo path = new FileInfo("C://sravan//data.txt");

	DateTime createdtime = path.CreationTime;
	
	
	Console.WriteLine("File is created at: {0}", createdtime);
	
	
	createdtime = path.LastAccessTime;
	Console.WriteLine("File is accessed at lastly: {0}", createdtime);
	
	
	createdtime = path.LastWriteTime;
	Console.WriteLine("File is lastly written on: {0} ", createdtime);

}
}
