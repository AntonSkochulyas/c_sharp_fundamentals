using System.Text.Json.Serialization;
using System.Transactions;

namespace HomeWork_8
{
    internal class Program
    {
        // 1
        abstract class Shape : IComparable<Shape>
        {
            private string? name;

            public string? Name { get { return name;} set { name = value; } }

            public Shape(string name) { this.name = name; }

            abstract public double Area();
            abstract public double Perimeter();

            public int CompareTo(Shape? other)
            {
                return this.Area() > other?.Area() ? 1 : -1;
            }
        }

        class Circle : Shape
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

        class Square : Shape
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

        static void Main(string[] args)
        {
            // a
            List<Shape> shapes = new List<Shape>()
            {
                new Circle("Circle_1", 10),
                new Square("Square_1", 10),
                new Circle("Circle_2", 20),
                new Square("Square_2", 20),
                new Circle("Circle_3", 30),
                new Square("Square_3", 30),
                new Circle("Circle_4", 40),
                new Square("Square_4", 40),
                new Circle("Circle_5", 50),
                new Square("Square_5", 50),
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Shape Name = {shape.Name}, Area = {shape.Area()}, Perimeter = {shape.Perimeter()}");
            }


            // b
            double maxPerimeter = 0;
            string? largestPerimeterName = null;

            foreach (Shape shape in shapes)
            {
                
                double currentPerimeter = shape.Perimeter();
                if (currentPerimeter > maxPerimeter)
                {
                    maxPerimeter = currentPerimeter;
                    largestPerimeterName = shape.Name;
                }
            }
            Console.WriteLine($"Largest perimeter Name = {largestPerimeterName}");

            
            // 3
            Console.WriteLine("Shapes Sorted by Area");

            shapes.Sort();

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Shape Name = {shape.Name}, Area = {shape.Area()}");
            }
        }
    }
}