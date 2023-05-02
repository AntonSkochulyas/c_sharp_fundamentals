
namespace HomeWork__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Homework3

            //1
            Console.WriteLine("Enter your string:");
            string? str = Console.ReadLine();
            Console.WriteLine($"Your string characters (a, o, i, e) count = {CalculateCharacters(str)}");

            //2
            Console.WriteLine("Enter your Month number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"This Month have {PrintDayCountInMonth(number)} days!");

            //3

            //Read from Console

            //int[] arr = new int[10];
            //for (int i = 0; i < 10; ++i)
            //{
            //    Console.WriteLine($"Enter {i + 1} number:");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            int[] arr2 = {10, 9, -8, 7, 6, 5, 4, 3, 2, 1};

            CalculateSumOrProduct(arr2, 5);
        }

        private static int CalculateCharacters(string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length; ++i)
                if (str[i] == 'a' || str[i] == 'o' || str[i] == 'i' || str[i] == 'e')
                    sum++;
            return sum;
        }

        private static int PrintDayCountInMonth(int count)
        {
            int[] arr = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            return arr[count - 1];
        }

        private static void CalculateSumOrProduct(int[] arr, int count)
        {
            bool sumOrProduct = true;

            for (int i = 0; i < count; ++i)
            {
                if (arr[i] < 0)
                {
                    sumOrProduct = false;
                    break;
                }
            }

            if (sumOrProduct)
                Console.WriteLine($"Your Sum is = {CalculateSumOfFirst(arr, count)}"); 
            else
                Console.WriteLine($"Your Product is = {CalculateProductOfLast(arr, count)}"); 
        }

        private static int CalculateSumOfFirst(int[] arr, int count)
        {
            int sum = 0;
            for (int i = 0; i < count; ++i)
                sum += arr[i];
            return sum;
        }

        private static int CalculateProductOfLast(int[] arr, int count)
        {
            int product = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i >= count; --i)
                product *= arr[i];
                
            return product; 
        }
    }
}