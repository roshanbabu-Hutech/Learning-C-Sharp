using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 20;
      int y = 18;
      if (x > y)
      {
        Console.WriteLine("x is greater than y");
      }
      if (20 > 18) 
      {
        Console.WriteLine("20 is greater than 18");
      } 
      int time = 22;
      if (time < 10) 
      {
        Console.WriteLine("Good morning.");
        } 
        else if (time < 20) 
        {
            Console.WriteLine("Good day.");
            } 
        else 
        {
            Console.WriteLine("Good evening.");
        }// Outputs "Good evening."

        //short hand if else
        int time = 20;
        string result = (time < 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);

        // Switch statement

        int day = 4;
        switch (day) {
            case 6:
            Console.WriteLine("Today is Saturday.");
            break;
            case 7:
            Console.WriteLine("Today is Sunday.");
            break;
            default:
            Console.WriteLine("Looking forward to the Weekend.");
            break;
}
            // Outputs "Looking forward to the Weekend."
    }
  }
}