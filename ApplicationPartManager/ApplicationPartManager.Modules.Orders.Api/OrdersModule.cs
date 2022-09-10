using ApplicationPartManager.Shared.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationPartManager.Modules.Orders.Api;

public class OrdersModule : IModule
{
    public string Name { get; }
    public void Register(IServiceCollection services, IConfiguration configuration)
    {
        services.AddOrdersModule();
    }

    public void Use(IApplicationBuilder app)
    {
    }

    public void Expose(IEndpointRouteBuilder endpoints)
    {
    }
}