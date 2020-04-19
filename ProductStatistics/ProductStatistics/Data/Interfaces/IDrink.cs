using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStatistics
{
    interface IDrink : IProduct
    {
        int Mililiters { get; set; }

        double Calories { get; set; }
    }
}
