using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics.interfaces
{
    interface IMenu
    {
        bool Contains(string productName);
        IProduct GetExistingProduct(string productName);
        void Register(IProduct product);
    }
}
