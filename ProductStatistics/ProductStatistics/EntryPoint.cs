using System;
using ProductStatistics.Core.Implementation;

namespace ProductStatistics
{
    class EntryPoint
    {
        private const string WelcomingMessage = "Добре дошли в ресторанта!\n Изберете една от следните категории при регистриране на нов продукт:\n салата, супа, основно ястие, десерт, напитка\nПри правене на поръчка изберете маса с номер от 1 до 30";

        static void Main(string[] args)
        {
            Console.WriteLine(WelcomingMessage);

            Engine engine = new Engine();

            engine.run();
        }
    }
}
