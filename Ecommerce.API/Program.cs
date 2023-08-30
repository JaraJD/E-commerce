using Ecommerce.MongoAdapter.Interfaces;
using Ecommerce.MongoAdapter;
using Ecommerce.Application.Gateway;
using Ecommerce.Application.UseCase;
using Ecommerce.Application.Gateway.Repository;
using Ecommerce.MongoAdapter.Repositories;
using Ecommerce.Application.Mapping;
using AutoMapper.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(config => config.AddDataReaderMapping(), typeof(MappingProfile));

builder.Services.AddSingleton<IContext>(provider => new Context(builder.Configuration.GetConnectionString("DefaultConnection"), "Ecommerce"));

builder.Services.AddScoped<ICategoryUseCase, CategoryUseCase>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

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
