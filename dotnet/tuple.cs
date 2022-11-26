using System;
  
public class TupleEx {
  
    // Main method
    public static  void Main()
    {
  
        // Creating 1-tuple
        // Using Create Method
        var My_Tuple1 = Tuple.Create("GeeksforGeeks");
  
        // Accessing the element of Tuple
        // Using Item property
        Console.WriteLine("Element of My_Tuple1: " + My_Tuple1.Item1);
        Console.WriteLine();
  
        // Creating 4-tuple
        // Using Create Method
        var My_Tuple2 = Tuple.Create(12, 30, 40, 50);
  
        // Accessing the element of Tuple
        // Using Item property
        Console.WriteLine("Element of My_Tuple2: " + My_Tuple2.Item1);
        Console.WriteLine("Element of My_Tuple2: " + My_Tuple2.Item2);
        Console.WriteLine("Element of My_Tuple2: " + My_Tuple2.Item3);
        Console.WriteLine("Element of My_Tuple2: " + My_Tuple2.Item4);
        Console.WriteLine();
  
        // Creating 8-tuple
        // Using Create Method
        var My_Tuple3 = Tuple.Create(13, "Geeks",
              67, 89.90, 'g', 39939, "geek", 10);
  
        // Accessing the element of Tuple
        // Using Item property
        // And print the 8th element of tuple
        // using Rest property
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item1);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item2);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item3);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item4);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item5);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item6);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item7);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Rest);
    }
} 