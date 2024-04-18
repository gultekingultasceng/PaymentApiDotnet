using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaymentApiDotnet.Context;
using PaymentApiDotnet.Factory;
using PaymentApiDotnet.RabbitMq;
using PaymentApiDotnet.RabbitMq.latest;
using PaymentApiDotnet.Repository;
using PaymentApiDotnet.Services;
using PaymentApiDotnet.Services.BankServices;
using PaymentApiDotnet.Services.BankServices.Base;
using PaymentApiDotnet.Services.Base;

namespace PaymentApiDotnet.IoC
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IBankFactory, BankFactory>();
            services.AddScoped<IBinRepository,BinRepository>();
            services.AddScoped<IBinService, BinService>();
            services.AddScoped<PaymentTransactionService>();
            services.AddScoped<DataContext>();
            services.AddScoped<VakıfBankService>();
            services.AddScoped<HalkBankService>();
            services.AddScoped<ZiraatService>();
            services.AddScoped<GarantiService>();
            services.AddScoped<TEBService>();
            services.AddScoped<SekerbankService>();
            services.AddScoped<AkbankService>();
            services.AddScoped<IsBankService>();
           
            services.Configure<RabbitMqConfiguration>(a => configuration.GetSection(nameof(RabbitMqConfiguration)).Bind(a));
            services.AddSingleton<IRabbitMqService, RabbitMqService>();
            services.AddSingleton<IConsumerService, ConsumerService>();
            services.AddSingleton<IProducerService, ProducerService>();
            services.AddHostedService<ConsumerHostedService>();
      
        }
    }
}
