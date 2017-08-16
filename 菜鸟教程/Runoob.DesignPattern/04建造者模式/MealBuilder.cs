#region

using _04建造者模式.Burger;
using _04建造者模式.ColdDrink;

#endregion

namespace _04建造者模式
{
    internal class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());

            return meal;
        }

        public Meal PrepareNonVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());

            return meal;
        }
    }
}