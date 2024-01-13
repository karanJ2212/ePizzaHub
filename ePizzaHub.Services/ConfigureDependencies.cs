using ePizzaHub.Core;
using ePizzaHub.Repositories.Implementations;
using ePizzaHub.Repositories.Interfaces;
using ePizzaHub.Services.Implementations;
using ePizzaHub.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ePizzaHub.Services
{
    public class ConfigureDependencies
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            //db
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            });

            //repositories
            services.AddScoped<IUserRepository, UserRepository>();

            //services
            services.AddScoped<IAuthService, AuthService>();
        }
    }
}
