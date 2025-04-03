using HexagonalArchitecture.Application.Services.Product.CreateProduct;
using HexagonalArchitecture.Application.Services.Product.GetProductAll;
using HexagonalArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using HexagonalArchitecture.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddScoped<ICreateProductCommandHandler, CreateProductCommandHandler>();
builder.Services.AddScoped<IGetProductAllQuery, GetProductAllQuery>();
builder.Services.AddInfrastructureServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();