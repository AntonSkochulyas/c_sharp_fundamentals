namespace Vending_Drinks_Machine
{
    internal class Espresso : Drink
    {
        public Espresso() { }
        public Espresso(string name)
        {
            Name = name;

            List<Ingredient> components = new List<Ingredient>
            {
                new Ingredient("sugar", 2, Amount.Grams),
                new Ingredient("coffee", 5, Amount.Grams),
                new Ingredient("cup", 1, Amount.Count),
                new Ingredient("money", 2, Amount.Dollars)
            };
            Components = components;
        }
    }
}
