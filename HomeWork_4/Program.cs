using System;

namespace HomeWork_4
{
    public class Person
    {
        private string? name = null;
        private DateTime birthYear;

        public string Name
        {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person() { }
        public Person (string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age(DateTime birth)
        {
            TimeSpan timeSpan = DateTime.Now - birth;
            int currentAge = (int)(timeSpan.TotalDays / 365);

            return currentAge;
        }

        public void Input()
        {
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your birth year in format (yyyy-mm-dd):");
            birthYear = DateTime.Parse(Console.ReadLine());
        }

        public void ChangeName(string name)
        {
            this.name = name;
        }

        public void Output()
        {
            this.ToString();
        }

        public override string ToString()
        {
            return $"Name = {name}, Age = {Age(birthYear).ToString()}";
        }

        public static bool operator==(Person a, Person b)
        { 
            return a.Name == b.Name;
        }

        public static bool operator!=(Person a, Person b)
        { 
            return a.Name != b.Name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[6];

            //foreach (Person person in persons)
            //    person.Input();

            persons[0] = new Person("Anton", new DateTime(1990, 03, 17));
            persons[1] = new Person("Kyryl", new DateTime(1989, 02, 24));
            persons[2] = new Person("Illya", new DateTime(1987, 07, 02));
            persons[3] = new Person("Anton", new DateTime(1980, 03, 17));
            persons[4] = new Person("Roman", new DateTime(1988, 05, 12));
            persons[5] = new Person("Misha", new DateTime(1986, 12, 03));

            foreach (Person person in persons)
                Console.WriteLine($"Name = {person.Name}, Age = {person.Age(person.BirthYear)}");

            foreach (Person person in persons)
            {
                if (person.Age(person.BirthYear) < 16)
                    person.ChangeName("Very Young");
            }

            foreach (Person person in persons)
                Console.WriteLine($"Name = {person.Name}, Age = {person.Age(person.BirthYear)}");

            for (int i = 0; i < persons.Length; ++i)
            {
                for (int j = i + 1; j < persons.Length; ++j)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"Name = {persons[i].Name}, Age = {persons[i].Age(persons[i].BirthYear)}");
                        Console.WriteLine($"Name = {persons[j].Name}, Age = {persons[j].Age(persons[j].BirthYear)}");
                    }
                }
            }
        }
    }
}