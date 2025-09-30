using Microsoft.EntityFrameworkCore;
using primer_parcialAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// EF Core → Azure SQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// Controllers + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 🔹 Swagger SIEMPRE habilitado (dev/prod) – lo pide el profe
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

// 🔹 Health check /ping
app.MapGet("/ping", () => Results.Ok("pong"));

app.Run();