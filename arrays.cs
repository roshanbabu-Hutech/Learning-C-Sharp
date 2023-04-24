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
    // sort an array
    // Sort a string
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    Array.Sort(cars);
    foreach (string i in cars)
    {
  Console.WriteLine(i);
  }
//   array helper methods
        int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // returns the largest value
      Console.WriteLine(myNumbers.Min());  // returns the smallest value
      Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

    //   Multi dimensional arrays
    int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
    numbers[0, 0] = 5;  // Change value to 5
    Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

    // loop through multi dimensional arrays

    int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

        for (int i = 0; i < numbers.GetLength(0); i++) 
        { 
        for (int j = 0; j < numbers.GetLength(1); j++) 
        { 
            Console.WriteLine(numbers[i, j]); 
        } 
        } 
    }
  }
}