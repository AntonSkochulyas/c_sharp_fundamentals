using System.Xml.Serialization;
//4. ------------------ - Автомат гарячих напоїв.
//Створити ієрархію класів для подання гарячих напоїв Автомату(кава, чай, капучіно та ін.)
//Створити програму для роботи Автомату у  режимах адмін та користувач
//У режимі адміна передбачити 	
//	Завантаження автомату водою, кава, чай, цукор
//	Вивід статистики наявності складових для приготування напоїв
//	Зміна цін на напої
//	Вилучення кешу
//У режимі користувача передбачити 		
//Замовлення напою(+ оплата)	

namespace Vending_Drinks_Machine
{
    internal class DrinkMachine
    {
        private static DrinkMachine? instance;
        public static DrinkMachine Instance
        {
            get
            {
                if (instance == null)
                    instance = new DrinkMachine();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        // constructor for deserialization
        public DrinkMachine()
        {
            instance = this;
        }
        public DrinkMachine(int password)
        {
            instance = this;
            Password = password;
        }

        public double Cash { get; set; }
        public int Password { get; private set; }
        public List<Ingredient> ingredients = new List<Ingredient>();
        private List<Drink> drinks = new List<Drink>();
        private Menu menu = new Menu();


        private void AddAllIngredients()
        {
            ingredients.Add(new Ingredient("sugar", 200, Amount.Grams, 1000));
            ingredients.Add(new Ingredient("water", 1000, Amount.Milliliters, 1000));
            ingredients.Add(new Ingredient("coffee", 200, Amount.Grams, 1000));
            ingredients.Add(new Ingredient("cup", 200, Amount.Count, 1000));
            ingredients.Add(new Ingredient("tea", 200, Amount.Grams, 1000));
            ingredients.Add(new Ingredient("milk", 200, Amount.Grams, 1000));
            ingredients.Add(new Ingredient("chocolate", 200, Amount.Grams));
            ingredients.Add(new Ingredient("money", 0, Amount.Dollars, 1000));
        }
        private void AddAllDrinks()
        {
            drinks.Add(new Espresso("Espresso"));
            drinks.Add(new Americano("Americano"));
            drinks.Add(new Cappucсino("Cappucсino"));
            drinks.Add(new FlatWhite("FlatWhite"));
            drinks.Add(new HotChocolate("HotChocolate"));
            drinks.Add(new Tea("Tea"));
        }

        public void InitializeMachine()
        {
            AddAllDrinks();
            AddAllIngredients();
            menu.ShowMenu();
        }

        public void CreateDrink(int number)
        {
            Drink? drink = GetDrinkByNumber(number);
            if (drink != null)
                drink.CreateDrink(ingredients, drink.Name);
        }

        public Drink? GetDrinkByNumber(int number)
        {
            Drink? currentDrink = null;
            Drinks drinkInEnum = (Drinks)number;
            foreach (Drink drink in drinks)
            {
                if (drink.Name == drinkInEnum.ToString())
                    return currentDrink = drink;
            }
            return currentDrink;
        }

        public double GetDrinkPrice(Drink drink)
        {
            double price = 0;
            foreach (Ingredient ing in drink.Components)
            {
                if (ing.Title == "money")
                    return price = ing.Count;
            }
            return price;
        }

        public bool AddRemoveIngredient(string name, double count, bool add)
        {
            bool result = false;

            for (int i = 0; i < ingredients.Count; i++)
            {
                if (ingredients[i].Title == name)
                {
                    AddMinusIngredientCount(ingredients[i], count, add);
                    result = true;
                }
            }
            return result;
        }

        private void AddMinusIngredientCount(Ingredient ingredient, double count, bool add)
        {
            if (add)
            {
                if ((ingredient.Count + count) > ingredient.MaxCount)
                    ingredient.Count = ingredient.MaxCount;
                else
                    ingredient.Count += count;
            }
            else
            {
                if ((ingredient.Count - count) < 0)
                    ingredient.Count = 0;
                else
                    ingredient.Count -= count;
            }
        }

        public bool ChangePrice(string name, double count)
        {
            bool result = false;

            for (int i = 0; i < drinks.Count; i++)
            {
                if (drinks[i].Name == name)
                {
                    for (int j = 0; j < drinks[i].Components.Count; j++)
                    {
                        if (drinks[i].Components[j].Title == "money")
                        {
                            drinks[i].Components[j].Count = count;
                            result = true;
                        }
                    }
                }
            }
            return result;
        }

        public void AddCash(double sum)
        {
            Console.Clear();

            foreach (Ingredient ingredient in ingredients)
            {
                if (ingredient.Title == "money")
                {
                    ingredient.Count += sum;
                    Console.WriteLine($"You add {sum} {ingredient.Number}");
                }
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void RemoveCash()
        {
            Console.Clear();
            Console.WriteLine($"You remove {Cash} dollars.");
            Cash = 0;
            Console.ReadLine();
            Console.Clear();
        }
    }
}
