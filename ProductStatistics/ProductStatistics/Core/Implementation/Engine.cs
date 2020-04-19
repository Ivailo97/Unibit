using System;
using System.Text.RegularExpressions;
using ProductStatistics.Core.Interfaces;
using ProductStatistics.Factories;

namespace ProductStatistics.Core.Implementation
{
    class Engine : IRun
    {
        private const string StatisticsCommand = "продажби";
        private const string EndCommand = "изход";
        private const string InputSeperator = @",\s";

        public Restourant Restourant { get; set; }

        public Engine()
        {
            Restourant = new Restourant();
        }

        public void run()
        {
            string line;

            while (!(line = Console.ReadLine()).Equals(EndCommand))
            {
                string[] tokens = Regex.Split(line, InputSeperator);

                if (line.Equals(StatisticsCommand))
                {
                    Console.WriteLine(Restourant.Statistics());
                    continue;
                }

                Command command = CommandFactory.Build(tokens);
                command.execute(Restourant);
            }

            Console.WriteLine(Restourant.Statistics());
        }
    }
}
