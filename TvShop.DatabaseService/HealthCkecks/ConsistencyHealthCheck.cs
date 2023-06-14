using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TvShop.DatabaseService.HealthCkecks
{
    public class ConsistencyHealthCheck : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            bool isHealthy = await IsDbConsistentAsync();
            return isHealthy 
                ? HealthCheckResult.Healthy("Database Consistency is OK") 
                : HealthCheckResult.Unhealthy("Database Consistency is ERROR");
        }

        private Task<bool> IsDbConsistentAsync()
        {
            return Task.FromResult(true);
        }
    }
}
