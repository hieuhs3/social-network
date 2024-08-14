using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using Repository;
using Repository.Repository;
using Data.Entity;
using Services;
using Microsoft.AspNetCore.Hosting;
namespace SocialNetwork.Extensions
{
    public static class ProgramExtension
    {
        public static IServiceCollection DataBaseExtension(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<AppDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly("SocialNetwork")));
        }
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {

            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<MapperService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            //services.AddScoped<IRepositoryBase<Product>, RepositoryBase<Product>>();

            // Add AutoMapper
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }

}
