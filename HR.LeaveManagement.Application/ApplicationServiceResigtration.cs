using System.Reflection;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace HR.LeaveManagement.Application;
public static class ApplicationServiceResigtration
{
    public static IServiceCollection ApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        //services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}
