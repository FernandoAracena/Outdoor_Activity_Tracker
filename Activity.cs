using Outdoor_Tracker_DI;
namespace Outdoor_Activity_Tracker
{
    internal class Activity : IActivity
    {
        private string UserName;
        private string Location;
        private double Distance;
        private double Duration;
        private int ElevationGain;
        private string ActivityType;

        public Activity(string userName, string location, double distance, double duration, int elevationGain, string activityType)
        {
            UserName = userName;
            Location = location;
            Distance = distance;
            Duration = duration;
            ElevationGain = elevationGain;
            ActivityType = activityType;
        }

        public virtual void ActivityInfo()
        {
            Console.WriteLine($"User : {UserName} - Location : {Location} - Distance : {Distance} km - Duration : {Duration} hours - {ElevationGain} - Activity : {ActivityType}");
        }
        public double ReturnDistance() 
        {
            return Distance;
        }
        public string ReturnActivityType()
        {
            return ActivityType;
        }
        public string ReturnUserName()
        {
            return UserName;
        }
        public double ReturnSpeed()
        {
            return Distance / Duration;
        }
    }
}
