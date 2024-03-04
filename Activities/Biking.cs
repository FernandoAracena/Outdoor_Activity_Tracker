using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outdoor_Activity_Tracker.Activities
{
    internal class Biking : Activity
    {
        private string BikeType { get; }
        private string TrailType { get; }
        private string DifficultyLevel { get; }

        public Biking(string userName, string location, double distance, double duration, int elevationGain, string activityType, string bikeType, string trailType, string difficultyLevel) : base(userName, location, distance, duration, elevationGain, activityType)
        {
            BikeType = bikeType;
            TrailType = trailType;
            DifficultyLevel = difficultyLevel;
        }

        public override void ActivityInfo()
        {
            base.ActivityInfo();
            Console.WriteLine($"Bike Type : {BikeType} - Trail Type : {TrailType} - Difficulty Level : {DifficultyLevel}");
        }
    }
}