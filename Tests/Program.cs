using System.Linq;
using System.Text.RegularExpressions;

namespace Tests
{
    internal class Program
    {
        public class Student
        {
            public int Rating { get; set; }
            public string Name { get; set; }
            public string Group { get; set; }
            public List<string> Subjects { get; } = new List<string>();

            public Student(int rating, string name, string group, List<string> subjects)
            {
                Rating = rating;
                Name = name;
                Group = group;
                Subjects = subjects;
            }

            public override bool Equals(object? obj)
            {
                if (obj is Student otherStudent)
                {
                    return Name == otherStudent.Name && Rating == otherStudent.Rating && Group == otherStudent.Group;
                }
                return false;
            }
        }
        public static IEnumerable<Student> Filter(IEnumerable<Student> students)
        {
            return students.Where(s => s.Rating >= 75 && (s.Subjects.Contains("Math") || s.Subjects.Contains("English")));
        }

        public static string SearchLongestWordStartingWithA(string sentence)
        {
            string result = String.Empty;

            for (int i = 0; i < sentence.Length; i++)
            {

            }

            return result;
}
        static void Main(string[] args)
        {
            List<string> subjects = new List<string>();
            subjects.Add("Math");
            subjects.Add("History");
            List<string> subjects2 = new List<string>();
            subjects2.Add("Math");
            subjects2.Add("English");
            List<Student> students = new List<Student>();
            students.Add(new Student(75, "Ivan", "pm", subjects));
            students.Add(new Student(76, "Petro", "kn", subjects2));

            IEnumerable<Student> students1 = Filter(students);

            foreach(Student student in students1)
            {
                Console.WriteLine($"{student.Name}, {student.Group}, {student.Subjects}");
            }

        }
    }
}