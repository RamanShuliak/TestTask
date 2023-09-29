using Microsoft.EntityFrameworkCore;
using TestTask.Business.ServicesImplementation;
using TestTask.Core.Abstractions;
using TestTask.Data.Abstractions;
using TestTask.Data.Abstractions.Repositories;
using TestTask.Data.Repositories;
using TestTask.DataBase;
using TestTask.DataBase.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IOrderService, OrderService>();

builder.Services.AddScoped<IRepository<User>, Repository<User>>();
builder.Services.AddScoped<IRepository<Order>, Repository<Order>>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<ApplicationDbContext>(
                optionBuilder => optionBuilder.UseSqlServer(connectionString));

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
