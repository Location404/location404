using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var identityService = builder.AddProject<Location404_IdentityService>("identity-service");
// identityService.WithUrl("https://identity-service.localhost:5001/");

builder.Build().Run();