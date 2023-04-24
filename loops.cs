//loops

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      while (i < 5) 
      {
        Console.WriteLine(i);
        i++;
      }
      int j = 0;
      do 
      {
        Console.WriteLine(j);
        j++;
      }
      while (j < 5);
    }

    // for loop
    for(int k = 0; k <= 10; k = k + 2)
      {
        Console.WriteLine(k);
      }
    //   Nested loops
    // Outer loop
    for (int i = 1; i <= 2; ++i) 
    {
    Console.WriteLine("Outer: " + i);  // Executes 2 times

    // Inner loop
    for (int j = 1; j <= 3; j++) 
    {
    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
  }
}
    }
  }
