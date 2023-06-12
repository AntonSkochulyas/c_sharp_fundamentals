namespace Vending_Drinks_Machine
{
    public abstract class Drink
    {
        public Drink() { }

        public string? Name { get; set; }

        public List<Ingredient>? Components { get; set; }
        public void CreateDrink(List<Ingredient> ingredients, string title)
        {
            if (CheckAvaliableIngredients(ingredients, Components))
            {
                RemoveIngredients(ingredients, Components);
                Preparing(title);
            }
            else
                Console.WriteLine("I don't have enough ingredients or money!");
        }

        private bool CheckAvaliableIngredients(List<Ingredient> ingredients, List<Ingredient> components)
        {
            int matching = 0;
            for (int i = 0; i < components.Count; ++i)
                for (int j = 0; j < ingredients.Count; ++j)
                    if (components[i].Title == ingredients[j].Title)
                    {
                        if (ingredients[j].Count - components[i].Count >= 0)
                            matching++;
                    }
            if (matching < components.Count)
                return false;
            else
                return true;
        }

        private void RemoveIngredients(List<Ingredient> ingredients, List<Ingredient> components)
        {
            for (int i = 0; i < components.Count; ++i)
                for (int j = 0; j < ingredients.Count; ++j)
                    if (components[i].Title == ingredients[j].Title)
                    {
                        if (ingredients[j].Title == "money")
                        {
                            DrinkMachine.Instance.Cash += ingredients[j].Count;
                            ingredients[j].Count -= components[i].Count;
                            ingredients[j].Count = 0;
                        }
                        else
                            ingredients[j].Count -= components[i].Count;
                    }
        }

        public void Preparing(string title)
        {
            Console.Clear();
            Console.WriteLine("Preparing...");
            Thread.Sleep(1000);
            Console.WriteLine("Add water...");
            Thread.Sleep(1000);
            Console.WriteLine("Add all ingredients...");
            Thread.Sleep(1000);
            Console.WriteLine("A little bit of love...");
            Thread.Sleep(1000);
            Console.WriteLine($"Your {title} is complete!");
            Thread.Sleep(1000);
            Console.WriteLine("Enjoy, have a nice day!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
