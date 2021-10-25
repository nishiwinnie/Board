using Board.Data;
using Board.Interface;
using Board.Repository;
using Board.Repository.Interface;
using Board.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Interface;

namespace Board.Extensions
{
    public static class ObjectsExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration){
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<IBoardRepository,BoardRepository>();
            services.AddScoped<ICommentsRepository,CommentsRepository>();
            services.AddScoped<ISprintRepository,SprintRepository>();
            services.AddScoped<IStatusRepository,StatusRepository>();
            services.AddScoped<ITaskRepository,TaskRepository>();
            services.AddScoped<ITaskTypeRepository,TaskTypeRepository>();
            services.AddScoped<ITokenService,TokenService>();
            services.AddDbContext<DataContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }); 
            return services;
        }
    }
}