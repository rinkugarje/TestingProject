using Microsoft.EntityFrameworkCore;
using Task8_UnitTesting.Context;
using Task8_UnitTesting.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IGadgetService, GadgetService>();

var gadgetConnectionString = builder.Configuration.GetConnectionString("GadgetDbConnection");
builder.Services.AddDbContext<GadgetDbContext>(u => u.UseSqlServer(gadgetConnectionString));



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
