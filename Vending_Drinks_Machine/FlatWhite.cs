namespace Vending_Drinks_Machine
{
    internal class FlatWhite : Drink
    {
        public FlatWhite() { }
        public FlatWhite(string name)
        {
            Name = name;

            List<Ingredient> components = new List<Ingredient>
            {
                new Ingredient("sugar", 2, Amount.Grams),
                new Ingredient("coffee", 5, Amount.Grams),
                new Ingredient("cup", 1, Amount.Count),
                new Ingredient("milk", 5, Amount.Grams),
                new Ingredient("money", 5, Amount.Dollars)
            };
            Components = components;
        }
    }
}
