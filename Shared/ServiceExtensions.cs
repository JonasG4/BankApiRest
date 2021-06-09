using Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public static class ServiceExtensions
    {
        public static void AddSharedInfraestructure(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddTransient<IDateTimeService, DateTimeService>();

        }
    }
}
