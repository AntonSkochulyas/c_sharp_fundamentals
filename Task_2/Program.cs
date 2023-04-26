using System.Diagnostics.Metrics;
using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            //Enter two integers numbers and check if they can represent the day and month. 
            //Output result on the console.

            //int number1 = AskUserValidNumber("Enter your Day Number:");
            //int number2 = AskUserValidNumber("Enter your Month Number:");

            //Console.WriteLine($"Can number be a day?: {((number1 > 0 && number1 < 31) ? "Yes" : "No")}");
            //Console.WriteLine($"Can number be a month?: {((number2 > 0 && number2 <= 12) ? "Yes" : "No")}");

            //Enter double  number  and get the first 2 digits after the point of this number
            //and output the sum of these numbers. For example: 3.456 -> 4+5=9

            Console.WriteLine("Enter double value:");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(number % 100);
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