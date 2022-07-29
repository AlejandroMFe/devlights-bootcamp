using GymDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GymAPI.Data;
using GymBusiness.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<GymAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GymAPIContext") ?? throw new InvalidOperationException("Connection string 'GymAPIContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<GymDbContext>(
    options => options.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True"));
builder.Services.AddTransient<DataSeedService>();

var app = builder.Build();

// Seed Data
//SeedData(app);

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


void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using var scope = scopedFactory?.CreateScope();
    var service = scope?.ServiceProvider.GetService<DataSeedService>();
    service?.Seed();
}