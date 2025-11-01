using DermaVision.Application.Features.CQRS.Handlers.CategoryHandlers;
using DermaVision.Application.Interfaces;
using DermaVision.Persistence.Context;
using DermaVision.Persistence.Repositories;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// --- CQRS/Repository Bağımlılık Kayıtları ---
builder.Services.AddScoped<DermaVisionContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetByIdCategoryQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();

// --- Controller ve Swagger Hizmetleri ---
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// 🔥 Swagger Ayarları
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "DermaVision API",
        Version = "v1",
        Description = "DermaVision Web API with CQRS and Repository Pattern"
    });
});

var app = builder.Build();

// --- Swagger her ortamda aktif ---
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "DermaVision API v1");
    c.RoutePrefix = "swagger"; // 👉 Artık https://localhost:7013/swagger adresinde açılır
});

// --- Middleware zinciri ---
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
