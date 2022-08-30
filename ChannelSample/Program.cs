using ChannelSample.Channels;
using ChannelSample.Requests;
using ChannelSample.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton<VideoProcessor>()
    .AddSingleton<FullHdVideoChannel>()
    .AddSingleton<UltraHdVideoChannel>()
    .AddHostedService<FullHdBackgroundVideoProcessor>()
    .AddHostedService<UltraHdBackgroundVideoProcessor>();

var app = builder.Build();

app.MapGet("/", () => "Channel Demo!");
app.MapPost("/videos",
    async (ProcessVideo request, FullHdVideoChannel fullHdVideoChannel, UltraHdVideoChannel ultraHdVideoChannel) =>
    {
        await fullHdVideoChannel.Channel.PublishAsync(request);
        await ultraHdVideoChannel.Channel.PublishAsync(request);
        return Results.Accepted();
    });

app.Run();