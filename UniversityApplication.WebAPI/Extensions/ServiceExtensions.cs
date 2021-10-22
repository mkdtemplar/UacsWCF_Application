using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using UniversityApplication.Data;
using UniversityApplication.Services;

namespace UniversityApplication.WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

        public static void ConfigureISSIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });

        public static void ConfigureSQLContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<UniversityDataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("sqlConnection"), 
                    b => b.MigrationsAssembly("UniversityApplication.Data")));

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();
    }
}