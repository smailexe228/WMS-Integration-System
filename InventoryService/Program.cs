builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();