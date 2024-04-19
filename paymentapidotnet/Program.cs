using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaymentApiDotnet.IoC;
using PaymentApiDotnet.RabbitMq;
using PaymentApiDotnet.Repositories.EFCore;
using PaymentApiDotnet.Services;
using PaymentApiDotnet.Services.Base;
using RabbitMQ.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddDbContext<RepositoryContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase"))
    );
ServiceRegistration.AddPersistenceService(builder.Services , builder.Configuration); // Dependency Injection

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});
//app.UseAuthorization();

app.MapControllers();

app.Run();


