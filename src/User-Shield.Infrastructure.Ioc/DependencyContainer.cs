using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using User_Shield.Application;
using User_Shield.Domain.Interfaces.Repositories;
using User_Shield.Infrastructure.Data.EntityFramework.Context;
using User_Shield.Infrastructure.Data.EntityFramework.Repositories;

namespace User_Shield.Infrastructure.Ioc
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();


            services.AddScoped<UsuarioService>();

            return services;
        }
    }
}
