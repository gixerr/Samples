﻿using System.Diagnostics;
using ChannelSample.Requests;

namespace ChannelSample.Services;

public class VideoProcessor
{
    private static readonly Random Random = new();
    private readonly ILogger<VideoProcessor> _logger;

    public VideoProcessor(ILogger<VideoProcessor> logger)
    {
        _logger = logger;
    }

    public async Task ProcessAsync(ProcessVideo request)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        _logger.LogInformation($"Started processing a {request.Quality} video for path {request.Path}...");
        await Task.Delay(TimeSpan.FromSeconds(Random.Next(3, 10)));
        stopwatch.Stop();
        _logger.LogInformation($"Completed processing a {request.Quality} video for path {request.Path} in {stopwatch.Elapsed}.");
    }
}