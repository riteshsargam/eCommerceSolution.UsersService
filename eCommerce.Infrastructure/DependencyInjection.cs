using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure;
public static class DependencyInjection
{
    /// <summary>
    /// Extension method to add infrastucture services 
    /// to the dependency injection container
    /// </summary>
    /// <param name=""></param>
    /// <returns></returns>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //TO DO: Add Services to the IoC container
        //Infrastructure service oftern include data access,
        //caching and other low-level components.

        services.AddSingleton<IUsersRepository, UsersRepository>();
        return services;
    }
}



