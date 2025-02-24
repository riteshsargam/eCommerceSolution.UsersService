using eCommerce.Core.ServiceContracts;
using eCommerce.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Core;
public static class DependencyInjection
{
    /// <summary>
    /// Extension method to add core services 
    /// to the dependency injection container
    /// </summary>
    /// <param name=""></param>
    /// <returns></returns>
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        //TO DO: Add Services to the IoC container
        //Core service oftern include data access,
        //caching and other low-level components.

        services.AddTransient<IUsersService, UsersService>();
        return services;
    }
}



