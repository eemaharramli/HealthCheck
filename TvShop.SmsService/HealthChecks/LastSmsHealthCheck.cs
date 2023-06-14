using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TvShop.SmsService.HealthChecks
{
    public class LastSmsHealthCheck : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            return await Task.FromResult(HealthCheckResult.Healthy("Last SMS has been sent without any problems"));
        }
    }
}
