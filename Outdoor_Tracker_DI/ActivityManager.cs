
namespace Outdoor_Tracker_DI
{
    public class ActivityManager
    {
        private readonly List<IActivity> _activitiesList;

        public ActivityManager()
        {
            _activitiesList = new List<IActivity>();
        }
        public void AddActivity(IActivity activity) { _activitiesList.Add(activity); }
        public void RemoveActivity(int index) { _activitiesList.RemoveAt(index); }   
        public void ShowUserActivities () 
        { 
            for (int i = 0; i < _activitiesList.Count; i++)
            {
                Console.Write($"{i} - ");
                _activitiesList[i].ActivityInfo();
            }
            Console.WriteLine();
        }   
        public void ShowUserStatistics() 
        {
            double sumDistance = 0;
            foreach (var activity in _activitiesList)
            {
                sumDistance += activity.ReturnDistance();
            }
            Console.WriteLine(sumDistance); 
        }
        public void FilterByActivity(string activity) 
        { 
            var filtredByActivity = _activitiesList.Where(x => x.ReturnActivityType() == activity); 
            foreach(var filtred in filtredByActivity)
            {
                filtred.ActivityInfo();
            }
        }
        public void FilterByUser(string username) 
        {
            var filtredByUserName = _activitiesList.Where(x => x.ReturnUserName() == username);
            foreach (var filtred in filtredByUserName)
            {
                filtred.ActivityInfo();
            }
        }
        public void FastestByActivity(string activity) 
        {
            var filtredByActivity = _activitiesList.Where(x => x.ReturnActivityType() == activity);
            var fastestByActivity = filtredByActivity.OrderByDescending(x => x.ReturnSpeed()); 
            foreach(var fastest in fastestByActivity)
            {
                Console.WriteLine();
                fastest.ActivityInfo();
                Console.WriteLine($"Speed : {fastest.ReturnSpeed()} km/h");
                Console.WriteLine();
            }
        }
    }
}