using Kolokwium_APBD1.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IDbService, DbService>();
builder.Services.AddDbContext<Kolokwium_APBD1.Models.ProjDbContext>(opt => opt.UseSqlServer("Data Source=db-mssql16.pjwstk.edu.pl;Initial Catalog=s17943;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
