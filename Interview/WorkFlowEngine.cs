namespace Interview
{
    public class WorkFlowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var item in workflow.GetActivities())
            {
                item.Execute();
            }
        }
    }
}