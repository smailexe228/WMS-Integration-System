using IntegrationGateway.Adapters;
using IntegrationGateway.DTOs;
using IntegrationGateway.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(SupplyToStockProfile));

builder.Services.AddScoped<SupplyIntegrationService>();

builder.Services.AddHttpClient<InventoryAdapter>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5003");
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();