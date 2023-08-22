using Microsoft.Extensions.Options;
using System.Net;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel(o =>
{
    o.Listen(IPAddress.Any, 5001, listenOptions =>
    {
        //listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
        ////listenOptions.UseConnectionLogging();
    });
});


// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
