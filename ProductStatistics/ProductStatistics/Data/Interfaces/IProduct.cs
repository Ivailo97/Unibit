using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics
{
    interface IProduct
    {
        string Name { get; set; }

        decimal Price { get; set; }
    }
}
