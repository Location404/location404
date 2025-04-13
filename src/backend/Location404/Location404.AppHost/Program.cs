using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var identityService = builder.AddProject<Location404_IdentityService_API>("identity-service");

builder.Build().Run();