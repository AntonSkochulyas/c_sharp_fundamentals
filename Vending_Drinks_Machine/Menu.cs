namespace Vending_Drinks_Machine
{
    public enum Drinks
    {
        Espresso = 1,
        Americano,
        Cappucсino,
        FlatWhite,
        HotChocolate,
        Tea,
        Exit
    }

    public enum Services
    {
        ShowStatistics = 1,
        AddIngredient,
        RemoveIngredient,
        ChangeDrinkPrice,
        RemoveCash,
        Exit
    }
    internal class Menu
    {
        private static int tableWidth = 52;
        public void ShowMenu()
        {
            while (true)
            {
                try
                {
                    ShowMenuElement<Drinks>("Menu");
                    int number = int.Parse(Console.ReadLine());

                    if (Enum.IsDefined(typeof(Drinks), number))
                    {
                        if (number == (int)Drinks.Exit)
                            return;
                        MakeOrder(number);
                    }
                    else if (number == DrinkMachine.Instance.Password)
                        ShowAdmin();
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You can use only available numbers!");
                    }
                }
                catch(Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Format, you can use only available numbers!");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void MakeOrder(int number)
        {
            Console.Clear();
            Drink? drink = DrinkMachine.Instance.GetDrinkByNumber(number);
            if (drink != null)
                Console.WriteLine($"{drink.Name} price is {DrinkMachine.Instance.GetDrinkPrice(drink)} dollars");

            Console.WriteLine("Enter your cash:");
            int money = int.Parse(Console.ReadLine());

            DrinkMachine.Instance.AddCash(money);
            DrinkMachine.Instance.CreateDrink(number);
        }

        private void ShowAdmin()
        {
            Console.Clear();

            while (true)
            {
                try
                {
                    ShowMenuElement<Services>("Services");
                    int number = int.Parse(Console.ReadLine());

                    if (Enum.IsDefined(typeof(Services), number))
                    {
                        if (number == (int)Services.Exit)
                        {
                            Console.Clear();
                            return;
                        }
                        Console.Clear();
                        ChooseAdminOperation(number);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You can use only available numbers!");
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Format, you can use only available numbers!");
                }

            }
        }

        private void ShowMenuElement<T>(string title) where T : Enum
        {
            Console.WriteLine(title);
            T[] menuElements = (T[])Enum.GetValues(typeof(T));
            for (int i = 0; i < menuElements.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Enum.GetName(typeof(T), menuElements[i])}");
            }
            Console.WriteLine("Enter your menu number:");
        }

        private void ChooseAdminOperation(int number)
        {
            switch (number)
            {
                case 1:
                    ShowStatistic();
                    break;
                case 2:
                    AddRemoveIngredientCommand("Add Ingredient", true);
                    break;
                case 3:
                    AddRemoveIngredientCommand("Remove Ingredient", false);
                    break;
                case 4:
                    ChangeDrinkPrice();
                    break;
                case 5:
                    DrinkMachine.Instance.RemoveCash();
                    break;
            }
        }

        private void ChangeDrinkPrice()
        {
            try
            {
                Console.WriteLine("Enter Drink Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter new Price:");
                double price = double.Parse(Console.ReadLine());

                if (DrinkMachine.Instance.ChangePrice(name, price))
                    Console.WriteLine("Successful");
                else
                    Console.WriteLine("We can't find this drink in base");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wrong Format");
            }
            Console.ReadLine();
            Console.Clear();
        }

        private void ShowStatistic()
        {
            Console.WriteLine("Machine Ingredients Status");
            PrintLine();
            PrintRow("Title", "Count", "Value");
            PrintLine();

            foreach (Ingredient ingredient in DrinkMachine.Instance.ingredients)
            {
                if (ingredient.Title == "money")
                    PrintRow(ingredient.Title, DrinkMachine.Instance.Cash.ToString(), ingredient.Number.ToString());
                else
                    PrintRow(ingredient.Title, ingredient.Count.ToString(), ingredient.Number.ToString());
            }

            PrintLine();
            Console.ReadLine();
            Console.Clear();
            // how many drinks buy
        }

        private void AddRemoveIngredientCommand(string title, bool add)
        {
            try
            {
                Console.WriteLine(title);
                Console.WriteLine("Enter Ingredient Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Ingredient Count:");
                double count = double.Parse(Console.ReadLine());

                if (DrinkMachine.Instance.AddRemoveIngredient(name, count, add))
                    Console.WriteLine("Successful");
                else
                    Console.WriteLine("We can't find this ingredient in base");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wrong Format");
            }
            Console.ReadLine();
            Console.Clear();
        }

        private void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        private void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
                row += AlignCentre(column, width) + "|";

            Console.WriteLine(row);
        }

        private string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
                return new string(' ', width);
            else
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
        }
    }
}
