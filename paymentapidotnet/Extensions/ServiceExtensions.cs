using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PaymentApiDotnet.Factory;
using PaymentApiDotnet.RabbitMq.latest;
using PaymentApiDotnet.Repositories.Base;
using PaymentApiDotnet.Repositories.Contracts;
using PaymentApiDotnet.Repositories.EFCore;
using PaymentApiDotnet.Services;
using PaymentApiDotnet.Services.BankServices;
using PaymentApiDotnet.Services.BankServices.Base;
using PaymentApiDotnet.Services.Base;

namespace PaymentApiDotnet.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(
            o => o.UseNpgsql(configuration.GetConnectionString("WebApiDatabase"))
            );
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager,RepositoryManager>();
        }

        public static void ConfigureRabbitMq(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<RabbitMqConfiguration>(a => configuration.GetSection(nameof(RabbitMqConfiguration)).Bind(a));
            services.AddSingleton<IRabbitMqService, RabbitMqService>();
            services.AddSingleton<IConsumerService, ConsumerService>();
            services.AddSingleton<IProducerService, ProducerService>();
            services.AddHostedService<ConsumerHostedService>();
        }
        public static void ConfigureServicesLayer(this IServiceCollection services)
        {
            services.AddScoped<PaymentTransactionService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IBinService, BinService>();
            services.AddScoped<IBankFactory, BankFactory>();
            services.AddTransient<VakıfBankService>();
            services.AddTransient<HalkBankService>();
            services.AddTransient<ZiraatService>();
            services.AddTransient<GarantiService>();
            services.AddTransient<TEBService>();
            services.AddTransient<SekerbankService>();
            services.AddTransient<AkbankService>();
            services.AddTransient<IsBankService>();
        }
    }
}
