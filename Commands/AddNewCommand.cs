using Outdoor_Activity_Tracker.Activities;
using Outdoor_Tracker_DI;

namespace Outdoor_Activity_Tracker.Controllers
{
    internal class AddNewCommand : Command
    {
        private readonly ActivityManager _activitiesList;
        public AddNewCommand(ActivityManager activitiesList) : base("1", "Add new Activity")
        {
            _activitiesList = activitiesList;
        }

        public override void RunCommand()
        {
            Console.WriteLine();
            Console.WriteLine("User Name :");
            string username = Console.ReadLine();
            Console.WriteLine("Location :");
            string location = Console.ReadLine();
            Console.WriteLine("Distance in Kilometers :");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Duration in Hours :");
            double duration = double.Parse(Console.ReadLine());
            Console.WriteLine("Elevation Gain in Meters :");
            int elevationgain = int.Parse(Console.ReadLine());
            Console.WriteLine("ActivityType :");
            Console.WriteLine("Biking - Hiking - Running - Skiing");
            string activitytype = Console.ReadLine();
            if (activitytype == "Biking")
            {
                Console.WriteLine("Bike Type :");
                Console.WriteLine("Mountain Bike - Road Bike - Hybrid Bike");
                string biketype = Console.ReadLine();                
                Console.WriteLine("Trail Type :");
                Console.WriteLine("Singletrack - Bike Path - Road");
                string trailtype = Console.ReadLine();                
                Console.WriteLine("Difficulty Level :");
                Console.WriteLine("Beginner - Intermediate - Advanced");
                string difficultylevel = Console.ReadLine();
                var biking = new Biking(username, location, distance, duration, elevationgain, activitytype, biketype, trailtype, difficultylevel);
                _activitiesList.AddActivity(biking);
                Console.WriteLine("Info about added Activity :");
                biking.ActivityInfo();
            }
            else if (activitytype == "Hiking")
            {
                Console.WriteLine("Terrain Type :");
                Console.WriteLine("Mountainous - Forest - Coastal - Desert");
                string terraintype = Console.ReadLine();
                Console.WriteLine("Trail Difficulty :");
                Console.WriteLine("Easy - Moderate - Difficult");
                string traildifficulty = Console.ReadLine();
                Console.WriteLine("Required Gear :");
                Console.WriteLine("Hiking Boots - Backpack - Water Bottle");
                string requiredGear = Console.ReadLine();
                var hiking = new Hiking(username, location, distance, duration, elevationgain, activitytype, terraintype, traildifficulty, requiredGear);
                _activitiesList.AddActivity(hiking);
                Console.WriteLine("Info about added Activity :");
                hiking.ActivityInfo();
            }
            else if (activitytype == "Running")
            {
                Console.WriteLine("Terrain Type :");
                Console.WriteLine("Trail - Road - Track");
                string terraintype = Console.ReadLine();
                Console.WriteLine("Pace :");
                Console.WriteLine("Sprint - Jog - Long Distance");
                string pacetype = Console.ReadLine();
                Console.WriteLine("Running Shoes :");
                Console.WriteLine("Salomon - Merrell - Alpha");
                string runningshoes = Console.ReadLine();
                var running = new Running(username, location, distance, duration, elevationgain, activitytype, terraintype, pacetype, runningshoes);
                _activitiesList.AddActivity(running);
                Console.WriteLine("Info about added Activity :");
                running.ActivityInfo();
            }
            else if (activitytype == "Skiing")
            {
                Console.WriteLine("Ski Type :");
                Console.WriteLine("Alpine -  Cross Country - Telemark");
                string skitype = Console.ReadLine();
                Console.WriteLine("Ski Resort :");
                Console.WriteLine("Haukeliseter - Sjusjøen - Nordfjell");
                string skiresort = Console.ReadLine();
                Console.WriteLine("Snow Condition :");
                Console.WriteLine("Powder - Packed - Icy");
                string snowcondition = Console.ReadLine();
                var skiing = new Skiing(username, location, distance, duration, elevationgain, activitytype, skitype, skiresort, snowcondition);
                _activitiesList.AddActivity(skiing);
                Console.WriteLine("Info about added Activity :");
                skiing.ActivityInfo();
            }
            Console.WriteLine();
        }
    }
}
