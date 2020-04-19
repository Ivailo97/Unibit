using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics
{
    abstract class CalorieDrink : CalorieProduct, IDrink
    {
        public int Mililiters { get; set; }

        protected CalorieDrink(string name, decimal price, int mililiters) : base(name, price)
        {
            Mililiters = mililiters;
        }
    }
}
