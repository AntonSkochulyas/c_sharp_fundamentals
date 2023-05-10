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
            string name = "Solovey";
            bool canFly = true;

            public void Fly()
            {
                Console.WriteLine($"Bird name = {name}, Bird can fly? {canFly}");
            }
        }

        class Plane : IFlyable
        {
            string mark = "Boing";
            float highFly = 10000f;

            public void Fly()
            {
                Console.WriteLine($"Plane mark = {mark}, Plane is flying up {highFly} meters");
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
            Console.WriteLine("__________________________________________________");

            List<int> myColl = new List<int>();
            Console.WriteLine("Enter 10 digits");
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine($"Enter {i + 1} digit");
                myColl.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var digit in myColl)
            {
                if (digit == -10)
                    Console.WriteLine(myColl.IndexOf(digit));
                if (digit > 20)
                    myColl.RemoveAt(digit);
            }
            Console.WriteLine("__________________________________________________");

            foreach (var digit in myColl)
                Console.WriteLine($"Digit = {digit}");


            Console.WriteLine("__________________________________________________");
            myColl.Insert(2, 1);
            myColl.Insert(8, -3);
            myColl.Insert(5, -4);

            /myColl.Sort();

            foreach (var digit in myColl)
                Console.WriteLine($"Digit = {digit}");
        }
    }
}