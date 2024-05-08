using NLog;
using PaymentApiDotnet.Extensions;
using PaymentApiDotnet.Services.Logger;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


LogManager.Setup().LoadConfigurationFromFile(String.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

builder.Services.AddControllers().
    AddApplicationPart(typeof(PaymentApiDotnet.Presentation.AssemblyReference).Assembly);


builder.Services.AddAutoMapper(typeof(PaymentApiDotnet.Services.AssemblyReference).Assembly);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureLoggingDatabase(builder.Configuration);
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureRabbitMq(builder.Configuration);
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureLoggerService();

var app = builder.Build();
var logger = app.Services.GetRequiredService<ILoggerService>();
app.ConfigureExceptionHandler(logger);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
if (app.Environment.IsProduction())
{
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});
app.MapControllers();
app.Run();


