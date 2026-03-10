var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var message = Environment.GetEnvironmentVariable("MESSAGE") ?? "default";

app.MapGet("/", () => Results.Json(message));

app.Run();