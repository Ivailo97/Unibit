using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics
{
    class Salad : IFood
    {
        public Salad(string name, decimal price, int grams)
        {
            Name = name;
            Price = price;
            Grams = grams;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Grams { get; set; }
    }
}
