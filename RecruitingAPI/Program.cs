using Recruiting.Infrastructure.Data;
using Recruiting.Infrastructure.Service;
using Recruiting.Infrastructure.Repository;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.ApplicationCore.Contract.Service;
using Microsoft.EntityFrameworkCore;
using RecruitingAPI.Utility;
using Microsoft.AspNetCore.Cors;
using JwtAuthenticationManager;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.
var connetionString = Environment.GetEnvironmentVariable("RecruitingDB");
builder.Services.AddDbContext<RecruitingDbContext>(options =>
{
    if (connetionString!=null && connetionString.Length > 1)
    {
        options.UseSqlServer(connetionString);
    }
    else
    {
        options.UseSqlServer(builder.Configuration["RecruitingDB"]);
    }
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});

builder.Services.AddCustomJwtTokenService();

builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();
builder.Services.AddScoped<ICandidateService, CandidateService>();

builder.Services.AddScoped<IEmployeeTypeService, EmployeeTypeService>();
builder.Services.AddScoped<IEmployeeTypeRepository, EmployeeTypeReository>();

builder.Services.AddScoped<IJobCategoryService, JobCategoryService>();
builder.Services.AddScoped<IJobCategoryRepository, JobCategoryRepository>();

builder.Services.AddScoped<IJobRequirementRepository, JobRequirementRepository>();
builder.Services.AddScoped<IJobRequirementService, JobRequirementService>();

builder.Services.AddScoped<ISubmissionRepository, SubmissionRepository>();
builder.Services.AddScoped<ISubmissionService, SubmissionService>();

builder.Services.AddScoped<IStatusRepository, StatusRepository>();
builder.Services.AddScoped<IStatusService, StatusService>();


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
app.UseRouting();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();
app.UseGlobalExceptionHandlingMiddleware();
app.MapControllers();

app.Run();

