using Microsoft.EntityFrameworkCore;
using Interview.Infrastructure.Data;
using Interview.Infrastructure.Repository;
using Interview.Infrastructure.Service;
using Interview.ApplicationCore.Contract.Repository;
using Interview.ApplicationCore.Contract.Service;
using InterviewAPI.Utility;
using System.Data;
 


var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var connectionString = Environment.GetEnvironmentVariable("InterviewDB");

builder.Services.AddDbContext<InterviewDbContext>(options =>
{
    if (connectionString.Length > 1)
    {
        options.UseSqlServer(connectionString);
    }
    else
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("InterviewDB"));

    }
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddScoped<InterviewDbConnection>(provider =>
{
    //var connectionString = 
    if (connectionString.Length > 1)
    {
        return new InterviewDbConnection(connectionString);
    }
    else
    {
        return new InterviewDbConnection(builder.Configuration.GetConnectionString("InterviewDB"));

    }
});

builder.Services.AddScoped<IRecruiterRepository, RecruiterRepository>();
builder.Services.AddScoped<IRecruiterService, RecruiterService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseGlobalExceptionHandlingMiddleware();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

