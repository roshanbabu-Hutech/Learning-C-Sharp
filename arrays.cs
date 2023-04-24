using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      Console.WriteLine(cars[0]);
      cars[0] = "Opel";
      Console.WriteLine(cars[0]);
    // Now outputs Opel instead of Volvo
    Console.WriteLine(cars.Length);// Outputs 4
    //loop through an array

    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    for (int i = 0; i < cars.Length; i++) {
        Console.WriteLine(cars[i]);
    }

    // forEach method

    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    foreach (string i in cars){
        Console.WriteLine(i);
    }
    }
  }
}