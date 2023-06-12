namespace Vending_Drinks_Machine
{
    internal class Americano : Drink
    {
        public Americano() { }
        public Americano(string name)
        {
            Name = name;

            List<Ingredient> components = new List<Ingredient>
            {
                new Ingredient("sugar", 2, Amount.Grams),
                new Ingredient("coffee", 5, Amount.Grams),
                new Ingredient("cup", 1, Amount.Count),
                new Ingredient("milk", 1, Amount.Grams),
                new Ingredient("money", 3, Amount.Dollars)
            };
            Components = components;
        }
    }
}
