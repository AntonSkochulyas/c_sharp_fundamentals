namespace HomeWork_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// 1
            try
            {
                Console.WriteLine("Enter first number:");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Result = {Div(number1, number2)}");
            }
            /// 2
            catch (FormatException ex)
            {
                Console.WriteLine("Format Exception, your number is in wrong format");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            /// 3
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; ++i)
            {
                try
                {
                    numbers.Add(ReadNumber(1, 100));
                    if (i > 0 && numbers[i] <= numbers[i - 1])
                    {
                        numbers.RemoveAt(i);
                        throw new ArgumentException("All next numbers must be greater!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("All next numbers must be greater!");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Format Exception, your number is in wrong format");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Your Number is out of Range");
                }
            }

            foreach (int i in numbers)
                Console.WriteLine($"Number = {i}");
        }

        static int Div(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("You can't divide by zero!");

            return a / b;
        }

        static int ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter your Number:");
            int number = int.Parse(Console.ReadLine());

            if (number < start || number > end)
                throw new Exception("This number out of Range 1 - 100, or in wrong format.");
            
            return number;
        }
    }
}