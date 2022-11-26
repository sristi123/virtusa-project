// C# program to copy the data of one file to
// another file by overwriting the same file name
using System;
using System.IO;

class GfG{
	
static void Main()
{
	string file;
	Console.WriteLine("Before copy:\n");
	file = File.ReadAllText("first/sai.TXT");
	Console.WriteLine("data in first:\n" + file);

	file = File.ReadAllText("last/sai.TXT");
	Console.WriteLine("data in last :\n" + file + "\n\n\n");
	

	File.Copy("first/sai.TXT", "last/sai.TXT", true);

	
	Console.WriteLine("After copy:\n");
	file = File.ReadAllText("first/sai.TXT");
	Console.WriteLine("data in first:\n" + file);

	file = File.ReadAllText("last/sai.TXT");
	Console.WriteLine("data in last :\n" + file + "\n\n\n");
}
}
