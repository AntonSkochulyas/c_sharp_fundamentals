namespace HomeWork_11
{
    internal class Program
    {
        public delegate void MyDel(int m);

        class Student
        {
            public string Name { get; set; }
            List<int> marks = new List<int>();
            public event MyDel? MarkChange;

            public void AddMark(int mark)
            {
                marks.Add(mark);
                MarkChange?.Invoke(mark);
            }
        }
        class Parent
        {
            public void OnMarkChange(int mark)
            {
                Console.WriteLine($"New Mark = {mark}");
            }
        }

        class Accountancy
        {
            public void PayingFellowship(int mark)
            {
                if (mark > 75)
                    Console.WriteLine("Good job you have your fellowship!");
                else
                    Console.WriteLine("Learn harder you lost your fellowship!");
            }
        }
        static void Main(string[] args)
        {
            Student student1 = new Student() { Name = "Anton" };
            Parent parent1 = new Parent();
            Accountancy accountant = new Accountancy();

            student1.MarkChange += parent1.OnMarkChange;
            student1.MarkChange += accountant.PayingFellowship;
            student1.AddMark(1);
            student1.AddMark(75);
            student1.AddMark(85);
        }
    }
}