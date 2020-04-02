using Hangfire.Annotations;
using Hangfire.Dashboard;

namespace HangFire.Scheduler.Filter
{
    public class DashboardAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize([NotNull] DashboardContext context)
        {
            //TODO: Authorization will be implement
            return true;
        }
    }
}
