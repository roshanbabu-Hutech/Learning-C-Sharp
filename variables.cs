//Variables and DataTypes
namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            string name = "John";
            Console.WriteLine(name);
            int myNum = 5;
            Console.WriteLine(myNum);
            double myDoubleNum = 5.99D;
            Console.WriteLine(myDoubleNum);
            char myLetter = 'D';
            Console.WriteLine(myLetter);
            bool myBool = true;
            Console.WriteLine(myBool);
            string myText = "Hello";
            Console.WriteLine(myText);
            //Constants
            const int myNum = 15;
            myNum = 20;
            Console.WriteLine(myNum); // error

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);


            int x = 5;
            int y = 6;
            Console.WriteLine(x + y); // Print the value of x + y

            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);

            int minutesPerHour = 60;
            int m = 60;
            Console.WriteLine(minutesPerHour);
            Console.WriteLine(m);


            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String

            // Type casting

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }
    }
}