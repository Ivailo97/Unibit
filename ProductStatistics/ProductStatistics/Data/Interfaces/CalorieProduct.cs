using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics
{
    abstract class CalorieProduct : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Calories { get; set; }
        protected CalorieProduct(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        protected abstract void InitCalories();
    }
}
