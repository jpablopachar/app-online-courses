using Application.Features.Courses.CreateCourse;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
                // config.AddOpenBehavior(typeof(ValidationBehavior<,>));
            });

            /* services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

            services.AddAutoMapper(typeof(DependencyInjection).Assembly); */

            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<CreateCourseCommand>();

            return services;
        }
    }
}