using PaymentApiDotnet.Extensions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().
    AddApplicationPart(typeof(PaymentApiDotnet.Presentation.AssemblyReference).Assembly);

builder.Services.AddAutoMapper(typeof(PaymentApiDotnet.Services.AssemblyReference).Assembly);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureRabbitMq(builder.Configuration);
builder.Services.ConfigureServiceManager();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
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


