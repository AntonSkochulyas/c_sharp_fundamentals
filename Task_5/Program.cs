namespace Task_5
{
    internal class Program
    {
        interface IFlyable
        {
            void Fly();
        }

        class Bird : IFlyable
        {
            string name;
            bool canFly;

            public void Fly()
            {
                Console.WriteLine($"Bird can fly? {canFly}");
            }
        }

        class Plane : IFlyable
        {
            string mark;
            float highFly;

            public void Fly()
            {
                Console.WriteLine($"Plane is flying up {highFly} meters");
            }
        }
        
        static void Main(string[] args)
        {
            List<IFlyable> flyableObjects = new List<IFlyable>();

            flyableObjects.Add(new Bird());
            flyableObjects.Add(new Plane());

            foreach(var flyObject in flyableObjects)
            {
                flyObject.Fly();
            }

            List<int> myColl = new List<int>();
            Console.WriteLine("Enter 10 digits");
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine($"Enter {i} digit");
                myColl.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var digit in myColl)
            {
                if (digit == -10)
                    Console.WriteLine(myColl.IndexOf(digit));
                if (digit > 20)
                {
                    myColl.RemoveAt(digit);
                }
            }
        }
    }
}