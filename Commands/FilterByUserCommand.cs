using Outdoor_Tracker_DI;

namespace Outdoor_Activity_Tracker.Commands
{
    internal class FilterByUserCommand : Command
    {
        private readonly ActivityManager _activitiesList;
        public FilterByUserCommand(ActivityManager activitiesList) : base("5", "Select a User and Show Activities")
        {
            _activitiesList = activitiesList;
        }
        public override void RunCommand()
        {
            Console.WriteLine(); 
            Console.WriteLine("Input a User Name to Filter :");
            string username = Console.ReadLine();
            _activitiesList.FilterByUser(username);
            Console.WriteLine();
        }
    }
}
