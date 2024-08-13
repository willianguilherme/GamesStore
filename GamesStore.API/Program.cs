using Asp.Versioning;
using GamesStore.Application;
using GamesStore.Infrastructure;
using GamesStore.Persistence;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Games Store v1", Version = "v1" });
    c.SwaggerDoc("v2", new OpenApiInfo { Title = "Games Store v2", Version = "v2" });
});

// Builder projects
builder.Services.BuilderApplicationServices(builder.Configuration);
builder.Services.BuilderInfrastructureServices(builder.Configuration);
builder.Services.BuilderPersistenceServices(builder.Configuration);

builder.Services.AddApiVersioning(option =>
{
    option.DefaultApiVersion = new ApiVersion(1, 0);
    option.AssumeDefaultVersionWhenUnspecified = true;
    option.ReportApiVersions = true;
    option.ApiVersionReader = new UrlSegmentApiVersionReader();
}).AddApiExplorer(options => {
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "GamesStore_v1");
        c.SwaggerEndpoint("/swagger/v2/swagger.json", "GamesStore_v2");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
