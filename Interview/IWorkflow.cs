using System.Collections.Generic;

namespace Interview
{
    public interface IWorkflow
    {
        
        void AddActivity(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}