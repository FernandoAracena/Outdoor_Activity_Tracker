using Outdoor_Tracker_DI;


namespace Outdoor_Activity_Tracker.Commands
{
    internal class DisplayListCommand : Command
    {
        private readonly ActivityManager _activitiesList;
        public DisplayListCommand(ActivityManager activitiesList) : base("2", "Display List of Activities")
        {
            _activitiesList = activitiesList;
        }
        public override void RunCommand()
        {
            _activitiesList.ShowUserActivities();
        }
    }
}
