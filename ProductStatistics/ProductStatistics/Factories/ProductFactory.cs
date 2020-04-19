using System;
using System.Text.RegularExpressions;

namespace ProductStatistics
{
    static class ProductFactory
    {
        private const string InvalidType = "Категорията на продукта може да е само една от следните: салата, напитка, супа, основно ястие, десерт";
        private const string InvalidName = "Наименованието на продукта трябва да съдържа само букви";
        private const string InvalidWeight = "Грамажът или милилитрите на продукта трябва да бъде цяло число в границите от 0 до 1000";
        private const string InvalidPrice = "Цената трябва да е положително реално число в границите от 0 до 100";

        public static IProduct Build(string type, string name, decimal price, int weight)
        {
            IProduct product;

            ValidateArguments(name, price, weight);

            switch (type)
            {
                case "салата":
                    product = new Salad(name, price, weight);
                    break;
                case "напитка":
                    product = new Drink(name, price, weight);
                    break;
                case "супа":
                    product = new Soup(name, price, weight);
                    break;
                case "основно ястие":
                    product = new MainDish(name, price, weight);
                    break;
                case "десерт":
                    product = new Dessert(name, price, weight);
                    break;
                default:
                    throw new ArgumentException(InvalidType);
            }

            return product;
        }

        private static void ValidateArguments(string name, decimal price, int weight)
        {
            if (!Regex.IsMatch(name, @"[a-zA-Zа-яА-Я]+$"))
            {
                throw new ArgumentException(InvalidName);
            }

            if (price < 0 || price > 100)
            {
                throw new ArgumentException(InvalidPrice);
            }

            if (weight < 0 || weight > 1000)
            {
                throw new ArgumentException(InvalidWeight);
            }
        }
    }
}
