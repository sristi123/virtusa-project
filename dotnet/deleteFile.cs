using System;
using System.IO;

namespace ConsoleApplication1
{
	class Progr
	{
		static void Main()
		{
			//method to delete file
			File.Delete("123.TXT");
			//confirmation message
			Console.WriteLine("File deleted successfully");
		}
	}
}