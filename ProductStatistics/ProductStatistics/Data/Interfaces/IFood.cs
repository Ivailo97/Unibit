using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics
{
    interface IFood : IProduct
    {
        int Grams { get; set; }

    }
}
