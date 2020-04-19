using System.Collections.Generic;
using System.Linq;
using ProductStatistics.interfaces;

namespace ProductStatistics
{
    class Menu : IMenu
    {
        public List<IProduct> Products { get; set; }

        public Menu()
        {
            InitAllProducts();
        }

        public bool Contains(string productName)
        {
            return Products.Any(x => x.Name.Equals(productName));
        }

        public IProduct GetExistingProduct(string productName)
        {
            return Products.Find(x => x.Name.Equals(productName));
        }

        public void Register(IProduct product)
        {
            Products.Add(product);
        }

        private void InitAllProducts()
        {
            Products = new List<IProduct>();
        }
    }
}
