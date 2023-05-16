namespace Tests
{
    internal class Program
    {
        public static List<string> CreateCommonList(Queue<string> q, Stack<string> s)
        {
            List<string> list = new List<string>();
            
            foreach (var item in q)
            {
                list.Add(item);
            }

            foreach (var item in s)
            {
                bool existed = false;

                foreach (var item2 in list)
                {
                    if (item == item2)
                    {
                        existed = true;
                        list.Remove(item2);
                        break;
                    }
                }

                if (!existed)
                {
                    list.Add(item);
                }
            }

            return list;
        }

        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("a");
            q.Enqueue("n");
            q.Enqueue("t");

            Stack<string> s = new Stack<string>();
          
            s.Push("n");
            s.Push("o");

            List<string> list = CreateCommonList(q, s);

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
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