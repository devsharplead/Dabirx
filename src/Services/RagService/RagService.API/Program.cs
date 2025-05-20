var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.AddApiServices();
builder.Services.AddProblemDetails();

var withApiVersioning = builder.Services.AddApiVersioning();

builder.AddDefaultOpenApi(withApiVersioning);

var app = builder.Build();

app.MapDefaultEndpoints();

var apiOrchestrator = app.NewVersionedApi("RagAgent");

//apiOrchestrator.MapOrdersApiV1()
//      .RequireAuthorization();

app.UseDefaultOpenApi();
app.Run();