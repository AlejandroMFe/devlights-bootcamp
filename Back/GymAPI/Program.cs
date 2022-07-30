﻿
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<GymAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GymAPIContext") ?? throw new InvalidOperationException("Connection string 'GymAPIContext' not found.")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<DataSeedService>();
builder.Services.AddDbContext<GymDbContext>(
    options => options.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True"));
builder.Services.AddControllers().AddJsonOptions(option => option.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));



var app = builder.Build();

// Seed Data
SeedData(app);

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