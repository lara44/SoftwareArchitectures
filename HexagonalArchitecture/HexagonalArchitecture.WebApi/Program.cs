
using HexagonalArchitecture.Application.Services.Product.GetProductAll;
using HexagonalArchitecture.Infrastructure;
using ATCMediator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddInfrastructureServices(builder.Configuration);

// builder.Services.AddScoped<IMediator, Mediator>();
// builder.Services.AddScoped<IQueryHandler<GetProductAllQuery, IEnumerable<Product>>, GetProductAllQueryHandler>();

builder.Services.AddATCMediator(
    typeof(Program).Assembly, 
    typeof(GetProductAllQueryHandler).Assembly
);



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