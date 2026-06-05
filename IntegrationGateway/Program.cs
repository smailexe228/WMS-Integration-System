builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(
    SupplyToStockProfile));

builder.Services.AddScoped<
    SupplyIntegrationService>();

builder.Services
.AddHttpClient<InventoryAdapter>(client =>
{
    client.BaseAddress =
        new Uri("http://localhost:5003");
});

builder.Services.AddSwaggerGen();