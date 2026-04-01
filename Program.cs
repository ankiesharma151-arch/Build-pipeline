using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Ankit 👋 .NET Docker is running!");
app.MapGet("/health", () => "Healthy ✅");

app.Run();
