namespace Tests
{
    internal class Program
    {
        public static List<string> CreateCommonList(Queue<string> q, Stack<string> s)
        {
            List<string> result = new List<string>();

            foreach (var item in q)
            {
                if (!s.Contains(item))
                    result.Add(item);
            }
            foreach (var item in s)
                if (!q.Contains(item))
                    result.Add(item);

            return result;
        }

        public static T FindValueByConditionOrDefault<T>(Dictionary<int, T> dictionary, Func<bool> predicate, T defaultValue)
        {
            foreach (var item in dictionary)
            {
                if (predicate())
                    return item.Value;
            }
            return defaultValue;
        }

        public static int Predicate()
        {
            return 1;
        }
    static void Main(string[] args)
        {
            Dictionary<int, int> my = new Dictionary<int, int>();
            my.Add(1, 2);
            int result = FindValueByConditionOrDefault<int>(my, Predicate, 10);
        }
    }
}


//List<int> numbers = new List<int>();

//for (int i = 0; i < 5; ++i)
//{
//    try
//    {
//        if (i == 0)
//            numbers.Add(ReadNumber(1, 100));
//        else
//            numbers.Add(ReadNumber(numbers[i - 1], 100));
//    }
//    catch (ArgumentException ex)
//    {
//        Console.WriteLine("All next numbers must be greater!");
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine("Format Exception, your number is in wrong format");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Your Number is out of Range");
//    }
//}

//foreach (int i in numbers)
//    Console.WriteLine($"Number = {i}");