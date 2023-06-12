
namespace Vending_Drinks_Machine
{
    public enum Amount
    {
        Milliliters,
        Grams,
        Count,
        Dollars,
        None
    }

    public class Ingredient
    {
        public string? Title { get; set; }
        public double Count { get; set; }
        public Amount Number { get; set; }

        public double MaxCount { get; set; }

        public Ingredient() { }
        public Ingredient(string title, double count, Amount amount, double maxCount = 1000)
        {
            this.Title = title;
            this.Count = count;
            this.Number = amount;
            this.MaxCount = maxCount;
        }
    }
}
