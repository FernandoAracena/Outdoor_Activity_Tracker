using Outdoor_Tracker_DI;

namespace Outdoor_Activity_Tracker.Commands
{
    internal class StatisticsCommand : Command
    {
        private readonly ActivityManager _activitiesList;
        public StatisticsCommand(ActivityManager activitiesList) : base("4", "Show Activities Statistics")
        {
            _activitiesList = activitiesList;
        }
        public override void RunCommand()
        {
            _activitiesList.ShowUserStatistics();
        }
    }
}
