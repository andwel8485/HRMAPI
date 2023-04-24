using Recruiting.Infrastructure.Data;
using Recruiting.Infrastructure.Service;
using Recruiting.Infrastructure.Repository;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.ApplicationCore.Contract.Service;
using Microsoft.EntityFrameworkCore;
using RecruitingAPI.Utility;


var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.
var connetionString = Environment.GetEnvironmentVariable("RecruitingDB");
builder.Services.AddDbContext<RecruitingDbContext>(options =>
{
    if (connetionString.Length > 1)
    {
        options.UseSqlServer(connetionString);
    }
    else
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("RecruitingDB"));

    }
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});



builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();
builder.Services.AddScoped<ICandidateService, CandidateService>();
builder.Services.AddScoped<IEmployeeTypeService, EmployeeTypeService>();
builder.Services.AddScoped<IEmployeeTypeRepository, EmployeeTypeReository>();
builder.Services.AddScoped<IJobCategoryService, JobCategoryService>();
builder.Services.AddScoped<IJobCategoryRepository, JobCategoryRepository>();

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

