var builder = DistributedApplication.CreateBuilder(args);

//var apiOrchestratorCache = builder.AddRedis("apiorchestrator")
//    .WithDataVolume()
//    .WithRedisCommander();


//var apiOrchestratorService = builder.AddProject<Projects.ApiOrchestratorService_API>("apiorchestratorservice")
//    .WithReference(apiOrchestratorCache)
//    .WaitFor(apiOrchestratorCache);

builder.Build().Run();
