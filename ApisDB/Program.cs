using ApisDB.Data;
using ApisDB.Services;
using ApisDB.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApisDB.Data.AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ViiMovitoX01Service>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();



// esto crea el modelo desde la base de datos 
/* Scaffold-DbContext "Server=XNCPOR205\SQLEXPRESS;Database=HOSPITAL;User Id=sa;Password=xenco2025;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Temp -Tables VII_MOVITO_X01 -Context "TempContext" -Force  */

