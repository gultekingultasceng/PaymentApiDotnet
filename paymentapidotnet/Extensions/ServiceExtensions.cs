using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using PaymentApiDotnet.Repositories.Base;
using PaymentApiDotnet.Repositories.Contracts;
using PaymentApiDotnet.Repositories.EFCore;
using PaymentApiDotnet.Services.Base;
using PaymentApiDotnet.Services.Contracts;
using PaymentApiDotnet.Services.Logger;
using PaymentApiDotnet.Services.MessageQueue.Rabbitmq;
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
        public static void ConfigureLoggingDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MongoDB");
            var mongoDbSection = configuration.GetSection("MongoDB");
            var databaseName = mongoDbSection["DatabaseName"];
            var collectionName = mongoDbSection["CollectionName"];
            services.AddSingleton<IMongoClient, MongoClient>(sp =>
            new MongoClient(connectionString));
            services.AddSingleton<IMongoDatabase>(sp =>
            sp.GetRequiredService<IMongoClient>().GetDatabase(databaseName));
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
        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerService,LoggerManager>();
        }
    }
}
