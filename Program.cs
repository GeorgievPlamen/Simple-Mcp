using Simple_Mcp.Services;
using Simple_Mcp.Tools;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMcpServer()
    .WithHttpTransport()
    .WithToolsFromAssembly();

builder.Services.AddHttpClient();
builder.Services.AddScoped<JsonPlaceholderClient>();

var app = builder.Build();

app.MapMcp();

await app.RunAsync();

