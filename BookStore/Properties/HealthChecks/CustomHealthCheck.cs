using System;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BookStore.Properties.HealthChecks
{
	public class CustomHealthCheck : IHealthCheck
	{
		public CustomHealthCheck()
		{
		}

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}

