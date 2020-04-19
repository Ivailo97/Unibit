using System;
using System.Linq;

namespace ProductStatistics.Core.Implementation
{
    class OrderCommand : Command
    {
        public OrderCommand(string[] data) : base(data)
        { }
        public override void execute(Restourant restourant)
        {
            int tableNumber = int.Parse(Data[0]);
            foreach (var productName in Data.Skip(1))
            {
                Order order;

                try
                {
                    order = new Order(tableNumber, productName);
                    restourant.OrderProduct(order);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
