using Projects;

var builder = DistributedApplication.CreateBuilder(args);
builder.AddProject<CacheHunt_Identity>("cachehunt-idenitity");

builder.Build().Run();