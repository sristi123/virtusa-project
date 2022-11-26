using System;
using System.IO;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main()
		{
			//method to delete file
			File.Delete("ABC.TXT");
			//confirmation message
			Console.WriteLine("File deleted successfully");
		}
	}
}