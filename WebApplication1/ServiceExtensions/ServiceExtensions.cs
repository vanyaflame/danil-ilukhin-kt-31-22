using WebApplication1.Interfaces.CafedresInterfaces;
using WebApplication1.Interfaces.WorkTimeInterfaces;

namespace WebApplication1.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICafedreService, CafedreService>();
            services.AddScoped<IWorkTimeService, WorkTimeService>();

            return services;
        }
    }
}
