
namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car_1 = new Car("Opel", "Black", 1000);
            Car car_2 = new Car("Opel", "White", 1000);
            Car car_3 = new Car("Mercedes", "Blue", 10500);

            car_1.ChangePrice(-10);
            car_1.Color = "White";
            car_1.Print();
        }
    }

    public class Car
    {
        private string? name = String.Empty;
        public string? Color{ get; set; }
        public double Price { get; set; }
        private const string companyName = "SoftServe";

        public Car() { }
        public Car(string name, string color, int price)
        {
            this.name = name;
            Color = color;
            Price = price;
        }

        public void Input()
        {
            Console.WriteLine("Enter your car name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your car color:");
            Color = Console.ReadLine();
            Console.WriteLine("Enter your car price:");
            Price = double.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Car name = {name}");
            Console.WriteLine($"Car color = {Color}");
            Console.WriteLine($"Car price = {Price}");
        }

        public void ChangePrice(double newPrice)
        {
            Price += Price * newPrice / 100;
        }

        public override string ToString()
        {
            return $"Name = {name}, Color = {Color}, Price = {Price}";
        }

        public static bool operator==( Car left, Car right )
        {
            return (left.name == right.name && left.Price == right.Price);
        }

        public static bool operator!=( Car left, Car right )
        {
            return (left.name != right.name && left.Price != right.Price);
        }
    }
}