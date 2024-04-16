using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaymentApiDotnet.Context;
using PaymentApiDotnet.IoC;
using PaymentApiDotnet.RabbitMq;
using PaymentApiDotnet.Services;
using PaymentApiDotnet.Services.Base;
using RabbitMQ.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase"))
    );
ServiceRegistration.AddPersistenceService(builder.Services); // Dependency Injection

var app = builder.Build();
var consumer = app.Services.GetService<PaymentEventConsumerRabbitmq>();
consumer.StartListening();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


