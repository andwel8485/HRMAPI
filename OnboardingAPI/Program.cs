using Microsoft.EntityFrameworkCore;
using Onboarding.Infrastructure.Data;
using Onboarding.ApplicationCore.Contract.Repository;
using Onboarding.ApplicationCore.Contract.Service;
using Onboarding.Infrastructure.Service;
using Onboarding.Infrastructure.Repository;
using OnboardingAPI.Utility;
using Microsoft.AspNetCore.Cors;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.
var connetionString = Environment.GetEnvironmentVariable("OnboardingDB");
builder.Services.AddDbContext<OnboardingDbContext>(options =>
{
    if (connetionString !=null && connetionString.Length > 1)
    {
        options.UseSqlServer(connetionString);
    }
    else
    {
        options.UseSqlServer(builder.Configuration["OnboardingDB"]);

    }
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddScoped<IEmployeeRoleRepository, EmployeeRoleRepository>();
builder.Services.AddScoped<IEmployeeRoleService, EmployeeRoleService>();

builder.Services.AddScoped<IEmployeeCategoryRepository, EmployeeCategoryRepository>();
builder.Services.AddScoped<IEmployeeCategoryService, EmployeeCategoryService>();

builder.Services.AddScoped<IEmployeeStatusRepository, EmployeeStatusRepository>();
builder.Services.AddScoped<IEmployeeStatusService, EmployeeStatusService>();


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
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.UseGlobalExceptionHandlingMiddleware();

app.MapControllers();

app.Run();

