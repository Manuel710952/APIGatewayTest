using ApiGateway.Controller;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using ApiGateway.Controller;

var builder = WebApplication.CreateBuilder(args);
/*builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();*/

builder.Configuration.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("ocelot.json", false, true).AddEnvironmentVariables();

builder.Services.AddOcelot(builder.Configuration);


var app = builder.Build();
await app.UseOcelot();
app.Run();
