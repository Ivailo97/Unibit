using System;
using System.Globalization;

namespace ProductStatistics.Core.Implementation
{
    class RegisterProductCommand : Command
    {
        public RegisterProductCommand(string[] data) : base( data)
        { }

        public override void execute(Restourant restourant)
        {
            string type = Data[0];
            string productName = Data[1];
            int weight = int.Parse(Data[2]);
            decimal price = decimal.Parse(Data[3], CultureInfo.InvariantCulture);

            IProduct product;
            try
            {
                product = ProductFactory.Build(type, productName, price, weight);
                restourant.AddToMenu(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
