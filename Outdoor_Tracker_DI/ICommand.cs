namespace Outdoor_Activity_Tracker
{
    public interface ICommand
    {
        string No {  get; }
        string Description { get; }
        void RunCommand();
    }
}