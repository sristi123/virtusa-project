using System;
using System.IO;

namespace IOSamples
{
  public class DirectoryUTCTime
  {
    public static void Main()
    {
    // Set the directory.
      string n = @"C:\test\newdir";
      DateTime dtime1 = new DateTime(2002, 1, 3);
      DateTime dtime2 = new DateTime(1999, 1, 1);

    //Create the directory.
      try
      {
          Directory.CreateDirectory(n);
      }
      catch (IOException e)
      {
          Console.WriteLine(e);
      }
      Directory.SetCreationTime(n, dtime1);
      Directory.SetLastAccessTimeUtc(n, dtime1);

        // Print to console the results.
      Console.WriteLine("Creation Date: {0}", Directory.GetCreationTime(n));
      Console.WriteLine("UTC creation Date: {0}", Directory.GetCreationTimeUtc(n));
      Console.WriteLine("Last write time: {0}", Directory.GetLastWriteTime(n));
      Console.WriteLine("UTC last write time: {0}", Directory.GetLastWriteTimeUtc(n));
      Console.WriteLine("Last access time: {0}", Directory.GetLastAccessTime(n));
      Console.WriteLine("UTC last access time: {0}", Directory.GetLastAccessTimeUtc(n));

        //Set the last write time to a different value.
      Directory.SetLastWriteTimeUtc(n, dtime2);
      Console.WriteLine("Changed last write time: {0}", Directory.GetLastWriteTimeUtc(n));
    }
  }
}