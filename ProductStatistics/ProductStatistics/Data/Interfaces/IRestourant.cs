using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics.interfaces
{
    interface IRestourant
    {
        string Statistics();
        void AddToMenu(IProduct product);
        void OrderProduct(Order order);
    }
}
