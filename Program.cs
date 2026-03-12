var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.MapGet("/", () => Results.Json("hello webhook v3 Francisco"));


// var message = Environment.GetEnvironmentVariable("MESSAGE") ?? "default";

// app.MapGet("/", () => Results.Json(message));

app.Run();