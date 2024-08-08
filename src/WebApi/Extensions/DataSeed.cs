using Bogus;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Models;

namespace WebApi.Extensions
{
    public static class DataSeed
    {
        public static async Task SeedDataAuthentication(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();

            var service = scope.ServiceProvider;
            var loggerFactory = service.GetRequiredService<ILoggerFactory>();

            try
            {
                var context = service.GetRequiredService<OnlineCoursesDbContext>();

                await context.Database.MigrateAsync();

                var userManager = service.GetRequiredService<UserManager<AppUser>>();

                if (!userManager.Users.Any())
                {
                    var userAdmin = new AppUser
                    {
                        FullName = "Admin",
                        UserName = "admin",
                        Email = "admin@yopmail.com"
                    };

                    await userManager.CreateAsync(userAdmin, "Password1234$");

                    await userManager.AddToRoleAsync(userAdmin, CustomRoles.ADMIN);

                    var userClient = new AppUser
                    {
                        FullName = "Juan Pablo Pachar",
                        UserName = "jppachar",
                        Email = "jppachar@yopmail.com"
                    };

                    await userManager.CreateAsync(userClient, "Password1234$");

                    await userManager.AddToRoleAsync(userClient, CustomRoles.CLIENT);
                }

                var courses = await context.Courses.Take(10).Skip(0).ToListAsync();

                if (!context.Set<CourseInstructor>().Any())
                {
                    var instructors = await context.Instructors.Take(10).Skip(0).ToListAsync();

                    foreach (var course in courses)
                    {
                        course.Instructors = instructors;
                    }
                }

                if (!context.Set<Qualification>().Any())
                {
                    foreach (var course in courses)
                    {
                        var fakerQualification = new Faker<Qualification>()
                            .RuleFor(q => q.Id, _ => Guid.NewGuid())
                            .RuleFor(q => q.Student, f => f.Name.FullName())
                            .RuleFor(q => q.Comment, f => f.Commerce.ProductDescription())
                            .RuleFor(q => q.Score, 5)
                            .RuleFor(q => q.CourseId, course.Id);

                        var qualifications = fakerQualification.Generate(10);

                        context.AddRange(qualifications);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                var logger = loggerFactory.CreateLogger<OnlineCoursesDbContext>();

                logger.LogError(exception.Message);
            }
        }
    }
}