using System.Net;
using System.Runtime.InteropServices;

namespace HomeWork_5
{
    internal class Program
    {
        interface IDeveloper
        {
            string Tool { get; set; }

            public void Create() { }
            public void Destroy() { }
        }

        public class Programmer : IDeveloper, IComparable<Programmer>
        {
            string language = String.Empty;
            public string Tool { get; set ; }


            public void Create()
            {
                Console.WriteLine("Create Method in class Programmer");
            }
            public void Destroy()
            {
                Console.WriteLine("Destroy Method in class Programmer");
            }

            public int CompareTo(Programmer other)
            {
                return string.Compare(Tool, other.Tool);
            }
        }

        public class Builder : IDeveloper, IComparable<Builder>
        {
            string tool = String.Empty;
            public string Tool { get; set; }

            public void Create()
            {
                Console.WriteLine("Create Method in class Builder");
            }
            public void Destroy()
            {
                Console.WriteLine("Destroy Method in class Builder");
            }

            public int CompareTo(Builder other)
            {
                return string.Compare(Tool, other.Tool);
            }
        }

        static void Main(string[] args)
        {
            // Interfaces

            List<IDeveloper> developers = new List<IDeveloper>();

            developers.Add(new Programmer() { Tool = "Java#" });
            developers.Add(new Programmer() { Tool = "Python" });
            developers.Add(new Programmer() { Tool = "C#" });
            developers.Add(new Programmer() { Tool = "C++" });
            developers.Add(new Programmer() { Tool = "C" });
            developers.Add(new Builder() { Tool = "Hammer" });
            developers.Add(new Builder() { Tool = "Scissors" });
            developers.Add(new Builder() { Tool = "Drill" });

            foreach (IDeveloper dev in developers)
            {
                dev.Create();
                dev.Destroy();
                Console.WriteLine(new String('-', 40));
            }
            
            List<Programmer> programmers = developers.OfType<Programmer>().ToList();
            List<Builder> builders = developers.OfType<Builder>().ToList();

            programmers.Sort();
            builders.Sort();

            developers = programmers.Cast<IDeveloper>().Concat(builders.Cast<IDeveloper>()).ToList();

            foreach (IDeveloper dev in developers)
            {
                Console.WriteLine($"Developer Tools = {dev.Tool}");
            }

            //Collections

            Dictionary<uint, string> dict = new Dictionary<uint, string>();

            for (uint i = 0; i < 7; ++i)
            {
                Console.WriteLine($"Enter {i + 1} unique number for User ID:");
                dict.Add(uint.Parse(Console.ReadLine()), "");
                Console.WriteLine($"Enter {i + 1} string for User Name:");
                dict[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter User ID:");
            uint id = uint.Parse(Console.ReadLine());
            if (id < 8 && dict.ContainsKey(id - 1))
                Console.WriteLine($"Name for this ID = {dict[id - 1]}");
            else
                Console.WriteLine("This dictionary is not contain this id");
        }
    }
}