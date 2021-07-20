using Board.Data;
using Board.Interface;
using Board.Repository;
using Board.Repository.Interface;
using Board.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Board.Extensions
{
    public static class ObjectsExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration){
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<ITokenService,TokenService>();
            services.AddDbContext<DataContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }); 
            return services;
        }
    }
}