using Application;
using RestfulApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices();

builder.Services.AddRestfulApiServices();

var app = builder.Build();

app.UseRestfulApiConfigurations();

app.Run();