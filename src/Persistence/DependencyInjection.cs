using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration) {
            services.AddDbContext<OnlineCoursesDbContext>(option => {
                // Registra los comandos SQL ejecutados y los presenta en la consola con un nivel de detalle informativo.
                option.LogTo(Console.WriteLine, new [] {
                    DbLoggerCategory.Database.Command.Name
                }, LogLevel.Information).EnableSensitiveDataLogging();

                option.UseSqlite(configuration.GetConnectionString("SQLiteConnection"));
            });

            return services;
        }
    }
}