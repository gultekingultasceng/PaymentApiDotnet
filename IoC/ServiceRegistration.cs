using Microsoft.Extensions.DependencyInjection;
using PaymentApiDotnet.Factory;
using PaymentApiDotnet.Services;
using PaymentApiDotnet.Services.BankServices;
using PaymentApiDotnet.Services.BankServices.Base;
using PaymentApiDotnet.Services.Base;

namespace PaymentApiDotnet.IoC
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IBankFactory, BankFactory>();
            services.AddTransient<PaymentTransactionService>();
            services.AddScoped<MastercardService>();
            services.AddScoped<VisaService>();
            services.AddScoped<AmexService>();
            services.AddScoped<JcbService>();
            services.AddScoped<EnrouteService>();
            services.AddScoped<DiscoverService>();
            services.AddScoped<DinersClubService>();

        }
    }
}
