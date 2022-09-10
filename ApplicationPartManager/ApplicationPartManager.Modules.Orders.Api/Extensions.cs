using ApplicationPartManager.Modules.Orders.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationPartManager.Modules.Orders.Api;

public static class Extensions
{
    public static IServiceCollection AddOrdersModule(this IServiceCollection services)
        => services.AddSingleton<IGreetingService, GreetingService>();
}