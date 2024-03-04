
namespace Outdoor_Tracker_DI
{
    public interface IActivity
    {
        void ActivityInfo();
        double ReturnDistance();
        string ReturnActivityType();
        string ReturnUserName();
        double ReturnSpeed();
    }
}
