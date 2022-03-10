using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SuperShop.Core.Contracts;
using SuperShop.Core.Interfaces;
using SuperShop.Data.Data;
using SuperShop.Data.Repository;
using SuperShop.Data.Services;
using superShopAlternativeImplementation.CORE.CONTRACTS;
using superShopAlternativeImplementation.CORE.Interfaces;
using System.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
//builder.Services.AddDbContext<SuperShopContext>(context =>
//context.UseSqlServer(Configuration.GetConnectionString("DefaultConnections"),
//b => b.MigrationsAssembly("Polidom.Data")));
builder.Services.AddDbContext<SuperShopContext>();
builder.Services.AddTransient<IMallRepository, MallRepository>();
builder.Services.AddTransient<IMallService, MallService>();
builder.Services.AddTransient<IBranchRepository, BranchRepository>();
builder.Services.AddTransient<IBranchService, BranchService>();

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
