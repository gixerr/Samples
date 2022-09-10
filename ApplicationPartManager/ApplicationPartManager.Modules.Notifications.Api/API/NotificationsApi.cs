using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace ApplicationPartManager.Modules.Notifications.API;

public static class NotificationsApi
{
    public static void UseNotificationsApi(this IEndpointRouteBuilder builder)
        => builder.MapGet("/notifications", () => "Notifications API");
}