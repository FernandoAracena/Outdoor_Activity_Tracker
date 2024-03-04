using System;
using System.Collections.Generic;
using System.Linq;
using Outdoor_Tracker_DI;

namespace Outdoor_Activity_Tracker
{
    internal class Command : ICommand
    {
        public string No { get; } 
        public string Description { get; }
        public Command(string no, string description)
        {
            No = no;
            Description = no + " - " + description;
        }
        
        public virtual void RunCommand()
        {
            Console.WriteLine("You have Selected :");
        }
    }
}
