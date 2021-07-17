using Board.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Board.Extensions
{
    public static class ObjectsExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration){
            
            services.AddDbContext<DataContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }); 
            return services;
        }
    }
}