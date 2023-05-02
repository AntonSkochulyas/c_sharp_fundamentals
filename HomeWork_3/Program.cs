
namespace HomeWork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HomeWork3]
            // Enter two integer numbers a and b.
            // Calculate how many integers in the range[a..b] are divided by 3 without remainder. //1..10 -> 3
            Console.WriteLine("Enter Range of two numbers:");
            Console.WriteLine("FirstNumber: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("SecondNumber: ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine($"In the range {first}..{second} are divided by 3 are = {CalculateDividedByThree(first, second)} numbers");

            // Enter some string text from the console. Print each second character.
            Console.WriteLine("Print some text");
            string? text = Console.ReadLine();
            PrintEachSecondCharacter(text);

            // Enter the name of the drink (coffee, tea, juice, water). 
            // Print the name and price of the drink.

            Console.WriteLine("Enter name of your drink: ");
            string? drink = Console.ReadLine();
            WritePriceOfDrink(drink);

            //Enter a sequence of positive integers(to the first negative).
            //Calculate the arithmetic average of the entered positive numbers.
            //1,6,3,9,-8-> (1 + 6 + 3 + 9) / 4

            Console.WriteLine("Enter your sequence of numbers:");
            string? numberSequence = Console.ReadLine();
            Console.WriteLine("Average of the entered positive numbers = " + CalculateAverageOfASequence(numberSequence));

            //Check if the entered year is a leap.
            Console.WriteLine("Enter your year:");
            int year = int.Parse(Console.ReadLine());
            CheckYearIsLeap(year);

            //Find the sum of digits of the entered integer number //(365 -> 3+6+5)
            Console.WriteLine("Enter your number: ");
            string? number = Console.ReadLine();
            WriteSumOfDigits(number);

            // Check if the entered integer number contains only odd digits.
            Console.WriteLine("Enter your number: ");
            string? value = Console.ReadLine();
            CheckOnlyOddDigits(value);
        }

        private static int CalculateDividedByThree(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; ++i)
            {
                if (i % 3 == 0)
                    sum++;
            }
            return sum;
        }

        private static void PrintEachSecondCharacter(string text)
        {
            for (int i = 1; i < text.Length; i += 2)
            {
                Console.Write(text[i] + " ");
            }
            Console.WriteLine();
        }

        private static void WritePriceOfDrink(string drink)
        {
            switch (drink.ToLower())
            {
                case "coffee":
                    Console.WriteLine($"{drink} = 60$");
                    break;
                case "tea":
                    Console.WriteLine($"{drink} = 45$");
                    break;
                case "juice":
                    Console.WriteLine($"{drink} = 30$");
                    break;
                case "water":
                    Console.WriteLine($"{drink} = 20$");
                    break;
                default:
                    Console.WriteLine("We don't have this drink in our menu!");
                    break;
            }
        }

        private static int CalculateAverageOfASequence(string sequence)
        {
            int i = 0;
            int sum = 0;

            while (i < sequence.Length)
            {
                if (sequence[i] == '-')
                    break;
                sum += int.Parse(sequence[i].ToString());
                i++;
            }
            return sum / i;
        }

        private static void CheckYearIsLeap(int year)
        {
            if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
                Console.WriteLine($"{year} is a Leap year!");
            else if (year % 4 == 0 && year % 400 != 0)
                Console.WriteLine($"{year} is a Leap year!");
            else
                Console.WriteLine($"{year} is not a Leap year!");
        }

        private static void WriteSumOfDigits(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; ++i)
                sum += int.Parse(number[i].ToString());
            Console.WriteLine($"Sum of digits is = {sum}");
        }

        private static void CheckOnlyOddDigits(string number)
        {
            for (int i = 0; i < number.Length; ++i)
            {
                if (int.Parse(number[i].ToString()) % 2 == 0)
                {
                    Console.WriteLine("Number have odd number in self");
                    return;
                }
            }
            Console.WriteLine("All Numbers is even");
        }
    }
}