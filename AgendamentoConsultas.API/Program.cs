using AgendamentoConsultas.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = "Server=127.0.0.1;Port=3306;Database=consultasdb;Uid=root;Pwd=root;";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));

builder.Services.AddDbContextPool<DataContext>(options => options.UseMySql(connectionString, serverVersion).EnableSensitiveDataLogging().EnableDetailedErrors());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
