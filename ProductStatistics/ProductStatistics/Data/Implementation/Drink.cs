using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics
{
    class Drink : CalorieDrink
    {
        private const double DrinkMultiplier = 1.5;

        public Drink(string name,decimal price,int mililiters ):base(name,price,mililiters)
        {
            InitCalories();
        }

        protected override void InitCalories()
        {
            Calories = Mililiters * DrinkMultiplier;
        }
    }
}
