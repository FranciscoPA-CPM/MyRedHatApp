var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.MapGet("/", () => Results.Json("hello webhook v7 Francisco este mensaje es el más nuevo y definitiva"));


// var message = Environment.GetEnvironmentVariable("MESSAGE") ?? "default";

// app.MapGet("/", () => Results.Json(message));

app.Run();