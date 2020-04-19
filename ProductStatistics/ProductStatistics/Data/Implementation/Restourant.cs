using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ProductStatistics.interfaces;

namespace ProductStatistics
{
    class Restourant : IRestourant
    {
        private const string ProductNotExist = "Product does not exist please choose another";

        private const int TablesCount = 30;
        public Menu Menu { get; set; }
        public List<IProduct> Sales { get; set; }
        public List<Drink> DrinkSales { get; set; }
        public List<Soup> SoupSales { get; set; }
        public List<MainDish> MainDishSales { get; set; }
        public List<Dessert> DessertSales { get; set; }
        public List<Salad> SaladSales { get; set; }

        public bool[] Tables { get; set; }

        public Restourant()
        {
            Menu = new Menu();
            Tables = new bool[TablesCount];
            InitSales();
        }

        public string Statistics()
        {
            StringBuilder report = new StringBuilder();
            int reservedTablesCount = Tables.Where(x => x == true).Count();
            decimal totalIncome = Sales.Select(x => x.Price).Sum();
            decimal saladIncome = SaladSales.Select(x => x.Price).Sum();
            decimal soupIncome = SoupSales.Select(x => x.Price).Sum();
            decimal mainDishIncome = MainDishSales.Select(x => x.Price).Sum();
            decimal dessertIncome = DessertSales.Select(x => x.Price).Sum();
            decimal drinkIncome = DrinkSales.Select(x => x.Price).Sum();
            report.AppendLine($"Общо маси заети през деня: {reservedTablesCount}");
            report.AppendLine($"Общо продажби: {Sales.Count} - {totalIncome}");
            report.AppendLine("По категории:");
            report.AppendLine($"Салата: {SaladSales.Count} - {saladIncome}");
            report.AppendLine($"Супа: {SoupSales.Count} - {soupIncome}");
            report.AppendLine($"Основно ястие: {MainDishSales.Count} - {mainDishIncome}");
            report.AppendLine($"Десерт: {DessertSales.Count} - {dessertIncome}");
            report.AppendLine($"Напитка: {DrinkSales.Count} - {drinkIncome}");
            return report.ToString();
        }

        public void AddToMenu(IProduct product)
        {
            Menu.Register(product);
        }

        public void OrderProduct(Order order)
        {
            EnsureValidProduct(order.ProductName);
            ReserveTable(order.TableNumber);
            TransferFromMenuToSales(Menu.GetExistingProduct(order.ProductName));
        }

        private void EnsureValidProduct(string productName)
        {
            if (!Menu.Contains(productName))
            {
                throw new ArgumentException(ProductNotExist);
            }
        }

        private void InitSales()
        {
            DrinkSales = new List<Drink>();
            SoupSales = new List<Soup>();
            MainDishSales = new List<MainDish>();
            DessertSales = new List<Dessert>();
            SaladSales = new List<Salad>();
            Sales = new List<IProduct>();

        }

        private void TransferFromMenuToSales(IProduct orderedProduct)
        {
            string type = orderedProduct.GetType().Name;

            Sales.Add(orderedProduct);

            switch (type)
            {
                case "Salad":
                    SaladSales.Add((Salad)orderedProduct);
                    break;
                case "Drink":
                    DrinkSales.Add((Drink)orderedProduct);
                    break;
                case "Soup":
                    SoupSales.Add((Soup)orderedProduct);
                    break;
                case "MainDish":
                    MainDishSales.Add((MainDish)orderedProduct);
                    break;
                case "Dessert":
                    DessertSales.Add((Dessert)orderedProduct);
                    break;
            }
        }

        private void ReserveTable(int tableNumber)
        {
            Tables[tableNumber - 1] = true;
        }
    }
}
