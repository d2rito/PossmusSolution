using Microsoft.AspNetCore.Builder;
using Possmus;
using Possmus.Interfaces;
using Possmus.Repository;
using Possmus.Servicios;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IEmpleoService, EmpleoService>();
builder.Services.AddScoped<IEmpleoRepository, EmpleoRepository>();
builder.Services.AddScoped<ICandidatoService, CandidatoService>();
builder.Services.AddScoped<ICandidatoRepository, CandidatoRepository>();
var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();