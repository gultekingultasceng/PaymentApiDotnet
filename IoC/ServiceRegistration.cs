using Microsoft.Extensions.DependencyInjection;
using PaymentApiDotnet.Context;
using PaymentApiDotnet.Factory;
using PaymentApiDotnet.RabbitMq;
using PaymentApiDotnet.Repository;
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
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IBankFactory, BankFactory>();
            services.AddScoped<IBinRepository,BinRepository>();
            services.AddTransient<PaymentTransactionService>();
            services.AddTransient<DataContext>();
            services.AddScoped<VakıfBankService>();
            services.AddScoped<HalkBankService>();
            services.AddScoped<ZiraatService>();
            services.AddScoped<GarantiService>();
            services.AddScoped<TEBService>();
            services.AddScoped<SekerbankService>();
            services.AddScoped<AkbankService>();
            services.AddScoped<IsBankService>();
            
           
            services.AddSingleton<PaymentEventProducerRabbitmq>(sp =>
            {
                return new PaymentEventProducerRabbitmq("localhost", "paymentQueue");
            });
            services.AddSingleton<PaymentEventConsumerRabbitmq>(sp =>
            {
                return new PaymentEventConsumerRabbitmq("localhost", "paymentQueue");
            });
        }
    }
}
