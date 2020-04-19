using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics
{
    class Dessert : CalorieFood
    {
        private const int CaloriesMultiplier = 3;
        public Dessert(string name, decimal price, int grams) : base(name, price, grams)
        {
            InitCalories();
        }
        protected override void InitCalories()
        {
            Calories = Grams * CaloriesMultiplier;
        }
    }
}
