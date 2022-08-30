﻿using ChannelSample.Channels;

namespace ChannelSample.Services;

public class FullHdBackgroundVideoProcessor : BackgroundService
{
    private readonly FullHdVideoChannel _channel;
    private readonly VideoProcessor _processor;

    public FullHdBackgroundVideoProcessor(FullHdVideoChannel channel, VideoProcessor processor)
    {
        _channel = channel;
        _processor = processor;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await foreach (var request in _channel.Channel.SubscribeAsync(stoppingToken))
        {
            await _processor.ProcessAsync(request with { Quality = "1080p" });
        }
    }
}