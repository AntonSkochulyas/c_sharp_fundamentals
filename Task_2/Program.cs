using System.Diagnostics.Metrics;
using System;
using System.ComponentModel;
using System.Security.Principal;

namespace Task_2
{
    enum TestCaseStatus
    {
        Pass,
        Fail,
        Blocked,
        WP,
        Unexecuted
    }

    struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            //Enter two integers numbers and check if they can represent the day and month. 
            //Output result on the console.

            int number1 = AskUserValidNumber("Enter your Day Number:");
            int number2 = AskUserValidNumber("Enter your Month Number:");

            Console.WriteLine($"Can number be a day?: {((number1 > 0 && number1 < 31) ? "Yes" : "No")}");
            Console.WriteLine($"Can number be a month?: {((number2 > 0 && number2 <= 12) ? "Yes" : "No")}");

            //Enter double  number  and get the first 2 digits after the point of this number
            //and output the sum of these numbers. For example: 3.456 -> 4+5=9

            Console.WriteLine("Enter double value:");
            double number = double.Parse(Console.ReadLine());
            int a = (int)((int)(number * 10)) % 10;
            int b = (int)((int)(number * 100.0)) % 10;
            Console.WriteLine($"Your number = {number}, A = {a}, B = {b}, A + B = {a + b}");

            // Enter integer number  h, representing the time of day (hour). 
            // Depending on the time of day, output greetings("Good morning!", "Good afternoon!", "Good evening!“ or "Good night!")

            Console.WriteLine("Enter your hour: ");
            int h = int.Parse(Console.ReadLine());
            string result = (h >= 6 && h <= 12) ? "Good morning" : (h > 12 && h < 18 ? "Good afternoon" : (h >= 18 && h < 24) ? "Good evening" : "Good night");
            Console.WriteLine(result);

            // Identify enum TestCaseStatus {Pass, Fail, Blocked, WP, Unexecuted}.  
            // Assign status “Pass” for variable test1Status and output result on the console.

            TestCaseStatus test1Staus = TestCaseStatus.Pass;
            Console.WriteLine(test1Staus);

            // Determine struct RGB that represents the color with fields red, green, blue(type byte).
            // Identify two variables of this type and enter their fields for white and black colors.

            RGB white = new RGB();
            {
                white.red = 255;
                white.green = 255;
                white.blue = 255;
            }

            RGB black = new RGB();
            {
                black.red = 0;
                black.green = 0;
                black.blue = 0;
            }
        }
        private static int AskUserValidNumber(string askQuestion = "")
        {
            int validNumber = 0;
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine(askQuestion);
                string? input = Console.ReadLine();

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
    }
}