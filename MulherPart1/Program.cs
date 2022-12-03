using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MulherPart1.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MulherPart1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MulherPart1Context") ?? throw new InvalidOperationException("Connection string 'MulherPart1Context' not found.")));

// Add services to the container.

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
