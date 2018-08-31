﻿using Otc.ProjectModel.Core.Application;
using Otc.ProjectModel.Core.Application.Services;
using Otc.ProjectModel.Core.Domain.Services;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class OtcProjectModelCoreApplicationServiceCollectionExtensions
    {
        public static IServiceCollection AddProjectModelCoreApplication(this IServiceCollection services, ApplicationConfiguration applicationConfiguration)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<ISubscriptionService, SubscriptionService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddSingleton(applicationConfiguration);

            return services;
        }
    }
}