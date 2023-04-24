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
    }
  }
