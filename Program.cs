using Outdoor_Activity_Tracker.Commands;
using Outdoor_Activity_Tracker.Controllers;
using Outdoor_Tracker_DI;


namespace Outdoor_Activity_Tracker
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            var activitiesList = new ActivityManager();
            var commands = new Command[]
            {
                new AddNewCommand(activitiesList),
                new DisplayListCommand(activitiesList),
                new RemoveCommand(activitiesList),
                new StatisticsCommand(activitiesList),
                new FilterByUserCommand(activitiesList),
                new FilterByActivityCommand(activitiesList),
                new DescendingOrderByActivityCommand(activitiesList)
            };
            while (true)
            {
                foreach (var command in commands)
                {
                    Console.WriteLine(command.Description);
                }
                var cmdStr = Console.ReadLine();
                var selectedCommand = commands.SingleOrDefault(cmd => cmd.No == cmdStr);
                selectedCommand.RunCommand();
            }
        }
    }
}