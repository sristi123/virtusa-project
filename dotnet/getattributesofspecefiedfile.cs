// C# program to illustrate the usage
// of File.GetAttributes(String) method

// Using System, System.IO
// and System.Text namespaces
using System;
using System.IO;
using System.Text;

class GetAttributes {
	public static void Main()
	{
	
		string path = @"file.txt";
		FileAttributes attributes = File.GetAttributes(path);
		if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden) {
			attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
			File.SetAttributes(path, attributes);
			Console.WriteLine("The {0} file is no longer hidden.", path);
		}
		else {
			File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
			Console.WriteLine("The {0} file is now hidden.", path);
		}
	}

	private static FileAttributes RemoveAttribute(FileAttributes attributes,
										FileAttributes attributesToRemove)
	{
		return attributes & ~attributesToRemove;
	}
}
