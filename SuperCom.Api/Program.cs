using Microsoft.EntityFrameworkCore;
using SuperCom.Application.Extensions;
using SuperCom.Api.Middleware;
using SuperCom.Persistence;
using SuperCom.Api.Extensions;
using SuperCom.Services.RabbitMq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApiServices(builder.Configuration);
builder.Services.AddSuperComApplicationServices(builder.Configuration);
builder.Services.AddRabbitMqServices(builder.Configuration);

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

// create scope for migrations, create db if dosent exist
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    var context = services.GetRequiredService<DataContext>();
    await context.Database.MigrateAsync();
    await Seed.SeedData(context);
}
catch (Exception ex)
{
    // create the logger against program
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "Program Migration Error occured");
}

app.Run();
