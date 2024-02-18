namespace MenuPlanner.BackgroundJobs
{
    public class JobFactory(IServiceProvider serviceProvider) : IJobFactory
    {
        private readonly IServiceProvider _serviceProvider = serviceProvider;

        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
            => (IJob)_serviceProvider.GetService(bundle.JobDetail.JobType);

        public void ReturnJob(IJob job)
        {
            // No action required
        }
    }
}
