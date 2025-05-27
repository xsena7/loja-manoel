using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configurações mínimas necessárias
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c => 
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Loja do Manoel", Version = "v1" });
});

var app = builder.Build();

// Pipeline essencial
app.UseSwagger();
app.UseSwaggerUI(c => 
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Loja v1");
    c.RoutePrefix = "swagger";
});

app.MapControllers();

app.Run();