
namespace HomeWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HomeWork_1
            //Define integer variable a(side of the square). 
            //Read value from the console and calculate the area and
            //perimeter of a square with length a.Output results on the console.

            int a = AskUserValidInt("Enter the size of the side of the square:");

            Console.WriteLine($"Square area is: {CalculateSquareArea(a)}.");
            Console.WriteLine($"Square perimeter is: {CalculateSquarePerimeter(a)}.");

            //Define string name and integer age.
            //Output question "What is your name?";
            //Read value name and output next question: "How old are you, (name)?".
            //Read value age and output whole information

            string name = AskUserValidString("What is your name?");
            int age = AskUserValidInt("What is your age?");
            ShowUserNameAndAge(name, age);

            //Read double number r(radius of a circle).
            //Calculate the length(l = 2 * pi * r), area(S = pi * r * r),
            //and volume(4 / 3 * pi * r * r * r) of a circle.

            double r = AskUserValidDouble("Enter radius of a circle:");

            ShowCircleParameters(CalculateCircleLength(r), CalculateCircleArea(r), CalculateCircleVolume(r));
        }

        private static void ShowCircleParameters(double circleLength, double circleArea, double circleVolume)
        {
            Console.WriteLine("Circle Parameters:");
            Console.WriteLine($"Length = {circleLength}");
            Console.WriteLine($"Area = {circleArea}");
            Console.WriteLine($"Volume = {circleVolume}");
        }

        private static double CalculateCircleVolume(double radius)
        {
            return 4.0 / 3 * Math.PI * radius * radius * radius;
        }

        private static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        private static double CalculateCircleLength(double radius)
        {
            return 2 * Math.PI * radius;
        }

        private static void ShowUserNameAndAge(string name, int age)
        {
            Console.WriteLine($"Your name is {name}. Your age is {age}.");
        }

        private static int CalculateSquareArea(int side)
        {
            return side * side;
        }

        private static int CalculateSquarePerimeter(int side)
        {
            return side * 4;
        }

        private static int AskUserValidInt(string askQuestion = "")
        {
            int validNumber = 0;
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine(askQuestion);
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    if (int.TryParse(input, out validNumber))
                    {
                        if (validNumber > 0)
                            valid = true;
                        else
                            Console.WriteLine("Number must be bigger than zero!");
                    }
                    else
                        Console.WriteLine("Invalid input. Enter a number!");
                }
                else
                    Console.WriteLine("Empty input. Enter a number!");
            }
            return validNumber;
        }

        private static double AskUserValidDouble(string askQuestion = "")
        {
            double validNumber = 0;
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine(askQuestion);
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    if (double.TryParse(input, out validNumber))
                    {
                        if (validNumber > 0)
                            valid = true;
                        else
                            Console.WriteLine("Number must be bigger than zero!");
                    }
                    else
                        Console.WriteLine("Invalid input. Enter a number!");
                }
                else
                    Console.WriteLine("Empty input. Enter a number!");
            }
            return validNumber;
        }

        private static string AskUserValidString(string askQuestion = "")
        {
            string validString = string.Empty;
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine(askQuestion);
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    int number = 0;

                    if (!int.TryParse(input, out number))
                    {
                        validString = input;
                        valid = true;
                    }
                    else
                        Console.WriteLine("Invalid input. Enter a text!");
                }
                else
                    Console.WriteLine("Empty input. Enter a text!");
            }
            return validString;
        }
    }
}