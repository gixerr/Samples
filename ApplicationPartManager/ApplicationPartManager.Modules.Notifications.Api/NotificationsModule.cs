using ApplicationPartManager.Modules.Notifications.API;
using ApplicationPartManager.Shared.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationPartManager.Modules.Notifications;

public class NotificationsModule : IModule
{
    public string Name => "Notifications";
    public void Register(IServiceCollection services, IConfiguration configuration)
    {
    }

    public void Use(IApplicationBuilder app)
    {
    }

    public void Expose(IEndpointRouteBuilder endpoints)
    {
        endpoints.UseNotificationsApi();
    }
}