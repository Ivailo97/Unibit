using System;

namespace ProductStatistics
{
    class Order
    {
        private const string InvalidTable = "Please choose a valid table number in range 1 to 30";

        private int _TableNumber;
        public int TableNumber
        {
            get { return _TableNumber; }
            set
            {
                if (value < 1 || value > 30)
                {
                    throw new ArgumentException(InvalidTable);
                }

                _TableNumber = value;
            }
        }

        public string ProductName { get; set; }

        public Order(int tableNumber, string productName)
        {
            TableNumber = tableNumber;
            ProductName = productName;
        }
    }
}
