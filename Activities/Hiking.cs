using Outdoor_Activity_Tracker.Activities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Outdoor_Activity_Tracker.Activities
{
    internal class Hiking : Activity
    {
        private string TerrainType { get; }
        private string TrailDifficulty { get; }
        private string RequiredGear { get; }
        public Hiking(string userName, string location, double distance, double duration, int elevationGain, string activityType, string terrainType, string trailDifficulty, string requiredGear) : base(userName, location, distance, duration, elevationGain, activityType)
        {
            TerrainType = terrainType;
            TrailDifficulty = trailDifficulty;
            RequiredGear = requiredGear;
        }

        public override void ActivityInfo()
        {
            base.ActivityInfo();
            Console.WriteLine($"Terrain Type : {TerrainType} - Trail Difficulty : {TrailDifficulty} - Required Gear : {RequiredGear}");
        }
    }
}