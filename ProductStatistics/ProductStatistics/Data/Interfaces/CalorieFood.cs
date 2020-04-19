using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics
{
    abstract class CalorieFood : CalorieProduct, IFood
    {
        public int Grams { get; set; }
      
        protected CalorieFood(string name, decimal price, int grams) : base(name,price)
        {
            Grams = grams;
        }
    }
}
