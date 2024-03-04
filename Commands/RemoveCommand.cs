using Outdoor_Tracker_DI;

namespace Outdoor_Activity_Tracker.Commands
{
    internal class RemoveCommand : Command
    {
        private readonly ActivityManager _activitiesList;
        public RemoveCommand(ActivityManager activitiesList) : base("3", "Remove Activity")
        {
            _activitiesList = activitiesList;
        }
        public override void RunCommand()
        {
            _activitiesList.ShowUserActivities();
            Console.WriteLine("Input the Index for the Activity to Remove :");
            int index = int.Parse(Console.ReadLine());
            _activitiesList.RemoveActivity(index);
        }
    }
}
