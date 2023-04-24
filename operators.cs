// Operators
namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)

            // assignment operator
            int x = 10;
            x += 5;
            Console.WriteLine(x);//15

            // comparison operator

            int x = 5;
            int y = 3;
            Console.WriteLine(x > y); // returns True because 5 is greater than 3

            // logical operator
            int x = 5;
            Console.WriteLine(x > 3 && x < 10); // returns True because 5 is greater than 3 AND 5 is less than 10

            // Math methods
            int num = Math.Max(5, 10);
            Console.WriteLine(num);

            int num1 = Math.Min(10,20);
            Console.WriteLine(num1);

            int num2 = Math.Sqrt(9);
            Console.WriteLine(num2);

            int num3 = Math.Abs(-9.17);
            Console.WriteLine(num3);

            int num4 = Math.Round(99.5);
            Console.WriteLine(num4);
        }
    }
}











