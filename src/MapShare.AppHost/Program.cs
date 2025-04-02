using Projects;

var builder = DistributedApplication.CreateBuilder(args);

// var username = builder.AddParameter("username", secret: true);
// var password = builder.AddParameter("password", secret: true);

// var postgresql = builder.AddPostgres("postgresql", username, password).WithPgAdmin(pgadmin => pgadmin.WithHostPort(5432));
// postgresql.AddDatabase("postgresdb");

// var redis = builder.AddRedis("redis").WithRedisInsight(redisInsight => redisInsight.WithHostPort(5540));

builder.Build().Run();