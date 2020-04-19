using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics
{
    class MainDish : CalorieFood
    {
        public MainDish(string name, decimal price, int grams) : base(name, price, grams)
        {
            InitCalories();
        }

        protected override void InitCalories()
        {
            Calories = Grams;
        }
    }
}
