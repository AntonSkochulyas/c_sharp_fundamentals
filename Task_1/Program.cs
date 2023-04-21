namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            //Define integer variables a and b.
            //Read values a and b from the console and calculate: a + b, a - b, a * b, a/ b.
            //Output results on the console.

            int a = AskUserValidNumber("Enter First number");
            int b = AskUserValidNumber("Enter Second number");

            CalculateAndWriteTwoNumbers(a, b);

            //Output question “How are you ?“. 
            //Define string variable answer.
            //Read value answer and output on the console: “You are(answer)".

            string answer = AskUserValidString("How are you ?");
            Console.WriteLine("You are " + answer);

            //Read 3 variables of char type. 
            //Write message: “You enter(first char), (second char), (3 char)”

            char c = AskUserValidChar("Enter First symbol");
            char d = AskUserValidChar("Enter Second symbol");
            char e = AskUserValidChar("Enter Third symbol");

            Console.WriteLine($"You enter ({c}), ({d}), ({e})");

            int f = AskUserValidNumber("Enter First number");
            int g = AskUserValidNumber("Enter Second number");

            CheckNumberPositive(f, g);
        }

        private static void CheckNumberPositive(int a, int b)
        {
            if (a > 0 && b > 0)
                Console.WriteLine("Both numbers are positive");
            else if (a > 0 || b > 0)
                Console.WriteLine("One of the numbers is positive");
            else
                Console.WriteLine("None of the numbers is positive");
        }

        private static void CalculateAndWriteTwoNumbers(int a, int b)
        {
            Console.WriteLine($"A + B = {a + b}");
            Console.WriteLine($"A - B = {a - b}");
            Console.WriteLine($"A * B = {a * b}");
            if (b != 0)
                Console.WriteLine($"A / B = {a / b}");
            else
                Console.WriteLine($"A / B = Infinity -- You can't divide by zero!");
        }

        private static int AskUserValidNumber(string askQuestion)
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
                        valid = true;
                    else
                        Console.WriteLine("Invalid input. Enter a number!");
                }
                else
                    Console.WriteLine("Empty input. Enter a number!");
            }
            return validNumber;
        }

        private static char AskUserValidChar(string askQuestion)
        {
            char validChar = '\0';

            try
            {
                Console.WriteLine(askQuestion);

                return validChar = char.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Try again!");

                return AskUserValidChar(askQuestion);
            }
        }

        private static string AskUserValidString(string askQuestion)
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