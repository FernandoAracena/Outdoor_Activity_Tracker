using Outdoor_Activity_Tracker.Activities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Outdoor_Activity_Tracker.Activities
{
    internal class Running : Activity
    {
        private string TerrainType { get; }
        private string Pace { get; }
        private string RunningShoes { get; }
        public Running(string userName, string location, double distance, double duration, int elevationGain, string activityType, string terrainType, string pace, string runningShoes) : base(userName, location, distance, duration, elevationGain, activityType)
        {
            TerrainType = terrainType;
            Pace = pace;
            RunningShoes = runningShoes;
        }

        public override void ActivityInfo()
        {
            base.ActivityInfo();
            Console.WriteLine($"Terrain Type : {TerrainType} - Pace : {Pace} - Running Shoes : {RunningShoes}");
        }
    }
}