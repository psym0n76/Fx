using System;
using Hangfire;

namespace Fx.Repository.Service
{
    public static class HangfireJobs
    {
        public static void Run(IBackgroundJobClient backgroundJobs)
        {
            FireAndForgetJobRunner();
            DelayedJobRunner();
            RecurringJobRunner();
            ContinuationsJobRunnerExample();
        }


        private static void RecurringJobRunner()
        {
            RecurringJob.AddOrUpdate(
                () => Console.WriteLine("Recurring every minute"),
                "0/5 * 1/1 * ? *");
        }

        private static void DelayedJobRunner()
        {
            var jobId = BackgroundJob.Schedule(() => Console.WriteLine("Delays job"), TimeSpan.FromMinutes(1));
        }

        private static string FireAndForgetJobRunner()
        {
            return BackgroundJob.Enqueue(() => Console.WriteLine("Fire and Forget"));
        }

        private static void ContinuationsJobRunnerExample()
        {
            var jobId = FireAndForgetJobRunner();

            ContinuationsJobRunner(jobId);
        }

        private static void ContinuationsJobRunner(string jobId)
        {
            BackgroundJob.ContinueJobWith(
                jobId,
                () => Console.WriteLine("Continuation!"));
        }
    }
}