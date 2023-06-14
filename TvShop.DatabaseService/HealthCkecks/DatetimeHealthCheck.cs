using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TvShop.DatabaseService.HealthCkecks
{
    public class DatetimeHealthCheck : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            string dateTimeDivideResult = await DateTimeDivide();
            if(dateTimeDivideResult == "Divided to 2")
            {
                return HealthCheckResult.Healthy("The date time milliseconds divided to 2");
            }
            else if(dateTimeDivideResult == "Divided to 3")
            {
                return HealthCheckResult.Degraded("The date time milliseconds divided to 3");
            }
            else
                return HealthCheckResult.Unhealthy(dateTimeDivideResult);
        }

        private Task<string> DateTimeDivide()
        {
            if (DateTime.Now.Millisecond % 2 == 0)
            {
                return Task.FromResult("Divided to 2");
            }
            else if (DateTime.Now.Millisecond % 3 == 0)
            {
                return Task.FromResult("Divided to 3");
            }
            else
                return Task.FromResult("Third case");
        }
    }
}
