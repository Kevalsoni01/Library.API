using Data.Context;
using IOC;
using Library.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Repository.IRepository;
using Repository;
using Services.Interfaces;
using Services.Services;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LibraryContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("BaseConnection")));
        dependencyContainer.REgisterServices(builder.Services);

    builder.Services.AddScoped<ILibrary_Student, Library_StudentServices>();
    builder.Services.AddScoped<ILibrary_StudentRepository, Library_StudentRepository>();

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
