using Application;
using Application.Interfaces;
using Infrastructure.Reports;
using Microsoft.AspNetCore.Identity;
using Persistence;
using Persistence.Models;
using WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration);

builder.Services.AddScoped(typeof(IReportService<>), typeof(ReportService<>));

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddIdentityCore<AppUser>(option =>
{
    option.Password.RequireNonAlphanumeric = false;
    option.User.RequireUniqueEmail = true;
}).AddRoles<IdentityRole>().AddEntityFrameworkStores<OnlineCoursesDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

await app.SeedDataAuthentication();

app.MapControllers();

app.Run();