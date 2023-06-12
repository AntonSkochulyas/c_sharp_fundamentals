namespace Vending_Drinks_Machine
{
    internal class HotChocolate : Drink
    {
        public HotChocolate() { }
        public HotChocolate(string name)
        {
            Name = name;

            List<Ingredient> components = new List<Ingredient>
            {
                new Ingredient("sugar", 2, Amount.Grams),
                new Ingredient("chocolate", 5, Amount.Grams),
                new Ingredient("cup", 1, Amount.Count),
                new Ingredient("money", 3, Amount.Dollars)
            };
            Components = components;
        }
    }
}
