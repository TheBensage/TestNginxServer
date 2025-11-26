using Microsoft.AspNetCore.Builder;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapGet("/", () => "Hello from .NET App!");
app.MapGet("/api", () => "This is the .NET /api endpoint!");
app.MapGet("/api/test", () => "This is the .NET /api/test endpoint!");

app.Urls.Add("http://0.0.0.0:5000");

app.Run();

