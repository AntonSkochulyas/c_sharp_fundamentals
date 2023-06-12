using System.Runtime.CompilerServices;

namespace Vending_Drinks_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkMachine drinkMachine = new DrinkMachine(287330);
            drinkMachine.InitializeMachine();
        }
    }
}