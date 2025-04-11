using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Location404_IdentityService>("identity-service");

builder.Build().Run();
