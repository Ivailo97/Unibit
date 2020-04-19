using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics
{
    class Soup : IFood
    {
        public Soup(string name, decimal price, int grams)
        {
            Name = name;
            Price = price;
            Grams = grams;
        }
        public int Grams { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
