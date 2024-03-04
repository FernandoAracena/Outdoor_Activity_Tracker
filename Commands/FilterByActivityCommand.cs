using Outdoor_Tracker_DI;

namespace Outdoor_Activity_Tracker.Commands
{
    internal class FilterByActivityCommand : Command
    {
        private readonly ActivityManager _activitiesList;
        public FilterByActivityCommand(ActivityManager activitiesList) : base("6", "Select an Activity and Show Users")
        {
            _activitiesList = activitiesList;
        }
        public override void RunCommand()
        {
            Console.WriteLine();
            Console.WriteLine("Input an Activity Name to Filter :");
            string activity = Console.ReadLine();
            _activitiesList.FilterByActivity(activity);
            Console.WriteLine();
        }
    }
}
