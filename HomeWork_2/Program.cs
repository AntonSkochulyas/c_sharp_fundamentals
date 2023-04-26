using System;

namespace HomeWork_2
{
    internal class Program
    {
        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized,
            PaymentRequired,
            Forbidden,
            NotFound
        }

        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public override string ToString()
            {
                return $"Dog name = {name}, Dog mark = {mark}, Dog age is {age}";
            }
        }

        static void Main(string[] args)
        {
            // HomeWork_2
            // Read 3 float numbers and check if they are all in the range [-5.5].

            Console.WriteLine("Enter 3 float numbers: ");
            float number1 = float.Parse(Console.ReadLine());
            float number2 = float.Parse(Console.ReadLine());
            float number3 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Are this numbers in the range?:" +
                $"  First number = {CheckRange(number1, -5f, 5f)}" +
                $", Second number = {CheckRange(number2, -5f, 5f)}" +
                $", Third number = {CheckRange(number3, -5f, 5f)}");


            // Read 3 integer numbers and output max and min of them.

            Console.WriteLine("Enter 3 int numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Min number is = {GetMinNumberOfThree(a, b, c)}, Max number is = {GetMaxNumberOfThree(a, b, c)}");

            // Read number of HTTP Error (400, 401,402, ...) and write the name of this error
            // (Declare enum HTTPError)

            Console.WriteLine("Write your Error number: ");
            int errorNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your Error is : {Enum.Parse(typeof(HTTPError), errorNumber.ToString())}");

            // Declare struct Dog with fields name, mark, age. 
            // Declare object myDog of Dog type and read values for it.
            // Output information on the console. (Override method ToString in struct)

            Console.WriteLine("Your Dog Info:");

            Dog myDog = new Dog();
            {
                myDog.name = "Karl";
                myDog.mark = "Medal";
                myDog.age = 5;
            }
            Console.WriteLine(myDog.ToString());
        }

    private static bool CheckRange(float number, float min, float max)
        {
            return ((number >= min && number <= max) ? true : false);
        }

        private static int GetMinNumberOfThree(int a, int b, int c)
        {
            return a < b ? (a < c ? a : c) : (b < c ? b : c);
        }

        private static int GetMaxNumberOfThree(int a, int b, int c)
        {
            return a > b ? (a > c ? a : c) : (b > c ? b : c);
        }
    }
}