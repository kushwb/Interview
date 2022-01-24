using System.Collections.Generic;

namespace Interview
{
    public class WorkFlow : IWorkflow
    {
        private List<IActivity> _activities = new List<IActivity>();        

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}