using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Outdoor_Activity_Tracker.Activities
{
    internal class Skiing : Activity
    {
        private string SkiType { get; }
        private string SkiResort { get; }
        private string SnowCondition { get; }
        public Skiing(string userName, string location, double distance, double duration, int elevationGain, string activityType, string skiType, string skiResort, string snowCondition) : base(userName, location, distance, duration, elevationGain, activityType)
        {
            SkiType = skiType;
            SkiResort = skiResort;
            SnowCondition = snowCondition;
        }

        public override void ActivityInfo()
        {
            base.ActivityInfo();
            Console.WriteLine($"SkiType : {SkiType} - Ski Resort : {SkiResort} - Snow Condition : {SnowCondition}");
        }
    }
}