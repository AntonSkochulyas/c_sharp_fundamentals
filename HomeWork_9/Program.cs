
namespace HomeWork_9
{
    internal class Program
    {
        public abstract class Shape : IComparable<Shape>
        {
            private string? name;

            public string? Name { get { return name; } set { name = value; } }

            public Shape(string name) { this.name = name; }

            abstract public double Area();
            abstract public double Perimeter();

            public int CompareTo(Shape? other)
            {
                return this.Area() > other?.Area() ? 1 : -1;
            }
        }

        public class Circle : Shape
        {
            double radius;

            public Circle(string name, double radius) : base(name) { this.radius = radius; }

            public override double Area()
            {
                return (Math.PI * radius * radius);
            }

            public override double Perimeter()
            {
                return (2 * Math.PI * radius);
            }
        }

        public class Square : Shape
        {
            double side;

            public Square(string name, double side) : base(name) { this.side = side; }

            public override double Area()
            {
                return side * side;
            }

            public override double Perimeter()
            {
                return 4 * side;
            }
        }

        public static void WriteShapeListToFile(IEnumerable<Shape> shapes)
        {
            string text = String.Empty;

            foreach (Shape shape in shapes)
                text += shape.Name + "\n";

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "shapes.txt";
            string filePath = Path.Combine(desktopPath, fileName);

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(text);
            }
        }

        public static void AddShapes(List<Shape> shapes)
        {
            shapes.Add(new Circle("CircleA", 2));
            shapes.Add(new Circle("CircleB", 4));
            shapes.Add(new Circle("CircleC", 6));
            shapes.Add(new Circle("CircleD", 1));
            shapes.Add(new Square("SquareA", 2));
            shapes.Add(new Square("SquareB", 4));
            shapes.Add(new Square("SquareC", 6));
            shapes.Add(new Square("SquareD", 1));
        }

        public static string[] ReadTextFile()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "text.txt";
            string filePath = Path.Combine(desktopPath, fileName);

            string[] text = File.ReadLines(filePath).ToArray();

            return text;
        }

        public static bool FindShapesByName(Shape shape)
        {
            return shape.Name.Contains('A');
        }


        static void Main(string[] args)
        {
            HomeWork_9(A)
            List<Shape> shapes = new List<Shape>();
            AddShapes(shapes);

            WriteShapeListToFile(shapes.Where(FindShapesByName));
            WriteShapeListToFile(shapes.Where(s => s.Area() > 10 && s.Area() < 100));
            shapes = shapes.Where(s => s.Perimeter() < 5).ToList();

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Shape = " + shape.Name);
            }


            //HomeWork_9(B)

            string[] fileText = ReadTextFile();

            // 1
            foreach (var line in fileText)
                Console.WriteLine(line.Length.ToString());

            // 2
            string longest = String.Empty;
            string shortest = fileText[0];
            foreach (var line in fileText)
            {
                if (line.Length > longest.Length)
                    longest = line;
                if (line.Length < shortest.Length)
                    shortest = line;
            }
            Console.WriteLine("longest line is = " + longest);
            Console.WriteLine("shortest line is = " + shortest);

            // 3
            foreach (var line in fileText)
                if (line.Contains("var"))
                    Console.WriteLine("This line consist word \"var\": " + line);
        }
    }
}