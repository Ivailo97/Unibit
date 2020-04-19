using ProductStatistics.Core.Implementation;

namespace ProductStatistics.Factories
{
    static class CommandFactory
    {
        public static Command Build(string[] data)
        {
            Command command;

            if (int.TryParse(data[0], out _))
            {
                command = new OrderCommand(data);
            }
            else
            {
                command = new RegisterProductCommand(data);
            }

            return command;
        }
    }
}
