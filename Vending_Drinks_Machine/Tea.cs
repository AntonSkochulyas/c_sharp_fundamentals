namespace Vending_Drinks_Machine
{
    internal class Tea : Drink
    {
        public Tea() { }
        public Tea(string name)
        {
            Name = name;

            List<Ingredient> components = new List<Ingredient>
            {
                new Ingredient("sugar", 2, Amount.Grams),
                new Ingredient("tea", 5, Amount.Grams),
                new Ingredient("cup", 1, Amount.Count),
                new Ingredient("money", 1, Amount.Dollars)
            };
            Components = components;
        }
    }
}
