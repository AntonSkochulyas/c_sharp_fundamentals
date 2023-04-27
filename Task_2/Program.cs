using System.Diagnostics.Metrics;
using System;
using System.ComponentModel;
using System.Security.Principal;
using System.Transactions;

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

    enum Food
    {
        Fish = 100,
        Mouse = 75,
        Bird = 50,
        Nothing = 0
    }

    struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;
    }

    struct Student
    {
        string lastName;
        int groupNumber;
    }

    internal class Cat
    {
        public int fullnessLevel = 0;

        public void EatSomething(Food food)
        {
            fullnessLevel += (int)food;
        }
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

            // Additional Tasks
            // Create class Cat. The cat should have a property "fullness level" and method "eat something".
            // Create enum Food (fish, mouse, ...). Each type of food should change the level of satiety differently.

            Cat myCat = new Cat();
            myCat.EatSomething(Food.Fish);
            myCat.EatSomething(Food.Mouse);
            Console.WriteLine(myCat.fullnessLevel);

            // Create struct Student with fields last name and group number.
            // Create array of students and output student names of a given group that begin with a given letter.
            // The last name and group number are entered from the console.

            Console.WriteLine("Enter your group size: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter each student LastName and group");
            string[] groupLastNames = new string[length];
            int[] groupNumbers = new int[length];

            for (int i = 0; i < length; ++i)
            {
                Console.WriteLine("Enter student LastName: ");
                groupLastNames[i] = Console.ReadLine();
                Console.WriteLine("Enter student group: ");
                groupNumbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter first LastName Letter: ");
            char firstLetter = Char.ToUpper(char.Parse(Console.ReadLine()));
            Console.WriteLine("All students with this first Letter: ");
            for (int j = 0; j < length; ++j)
            {
                if (firstLetter == groupLastNames[j][0])
                    Console.WriteLine($"{groupLastNames[j]}, group = {groupNumbers[j]}");
            }
        }

        public static uint LeastCommonMultiple(uint value1, uint value2)
        {
            uint i = 1;
            while (value1 % i == 0 && value2 % i == 0)
                i++;
            return i;
        }

        public static uint ReturnMin(uint a, uint b)
        {
            if (a == 0 || b == 0)
                return 0;
            if (a == b)
                return a;
            if (a > b)
                return ReturnMin(a - b, b);

            return ReturnMin(a, b - a);
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