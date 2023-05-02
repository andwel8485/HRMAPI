using Authentication.Infrastructure.Data;
using Authentication.ApplicationCore.Entity;
using Authentication.ApplicationCore.Contract.Repository;
using Authentication.ApplicationCore.Contract.Service;
using Authentication.Infrastructure.Service;
using Authentication.Infrastructure.Repository;
using AuthenticationAPI.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JwtAuthenticationManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connetionString = Environment.GetEnvironmentVariable("AuthenticationsDB");
builder.Services.AddDbContext<AutheticationDbContext>(options =>
{
    if (connetionString != null && connetionString.Length > 1)
    {
        options.UseSqlServer(connetionString);
    }
    else
    {
        options.UseSqlServer(builder.Configuration["AuthenticationsDB"]);

    }
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});


builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AutheticationDbContext>()
    .AddDefaultTokenProviders();


builder.Services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();


builder.Services.AddSingleton<JwtTokenHandler>();


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

app.UseAuthorization();

app.UseGlobalExceptionHandlingMiddleware();

app.MapControllers();

app.Run();

