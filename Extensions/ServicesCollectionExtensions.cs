using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RvEzzy.Services.Interface;
using Microsoft.Extensions.Configuration;
using RvEzy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using RvEzzy.Services;
using RvEzy.Data.EntityFramework;

namespace RvEzy.Api.Services
{
    public static partial class ServicesCollectionExtensions
    {
        public static string DefaultSchema = "rvezy";

        public static void AddRvEzyServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RvEzyDbContext>(options =>
                options
                    .UseSqlServer(configuration.GetConnectionString("DatabaseConnection"),
                        x => x.MigrationsHistoryTable("__MigrationHistory", DefaultSchema))
                    .ReplaceService<IMigrationsAnnotationProvider, RvEzyAnnotationProvider>()
                    .ReplaceService<IMigrationsSqlGenerator, RvEzyMigrationSqlGenerator>());
            services.AddAutoMapper(typeof(Startup));            
            services.AddTransient<IListingService, ListingsService>();
            services.AddOptions();
        }

    }

}
