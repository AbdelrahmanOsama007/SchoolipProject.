// SchoolipProject.Core namespace
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using SchoolipProject.Core.Feauters.Student.Qeuries.Handelrs;
using System.Reflection; // Make sure this is included if not already

namespace SchoolipProject.Core
{
    public static class ModuleCoreDependencies
    {
        // Registering the MediatR services from the current assembly
        public static IServiceCollection RegisterCoreDependencies(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            // Registering the automapper services from the current assembly
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
      
    }
}
