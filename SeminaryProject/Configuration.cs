using Seminary.BL;
using Seminary.DAL;

namespace SeminaryProject
{
    public static class Configuration
    {
        public static void ConfigurationServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
