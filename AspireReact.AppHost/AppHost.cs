var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireReact_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.Build().Run();
