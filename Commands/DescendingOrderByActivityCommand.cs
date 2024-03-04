using Outdoor_Activity_Tracker.Commands;
using Outdoor_Tracker_DI;


namespace Outdoor_Activity_Tracker.Commands
{
    internal class DescendingOrderByActivityCommand : Command
    {
        private readonly ActivityManager _activitiesList;
        public DescendingOrderByActivityCommand(ActivityManager activitiesList) : base("7", "Show Fastest Users By Activity")
        {
            _activitiesList = activitiesList;
        }
        public override void RunCommand()
        {
            Console.WriteLine();
            Console.WriteLine("Input an Activity Name to Filter :");
            string activity = Console.ReadLine();
            _activitiesList.FastestByActivity(activity);
            Console.WriteLine();
        }
    }
}