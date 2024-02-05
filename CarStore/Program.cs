using CarStore.BL.Interfaces;
using CarStore.BL.Service;
using CarStore.DL.Interfaces;
using CarStore.DL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add services to the container.
builder.Services.AddSingleton<ICarRepository, CarRepository>();
builder.Services.AddSingleton<ICarService, CarService>();
builder.Services.AddSingleton<IBrandRepository, BrandRepository>();
builder.Services.AddSingleton<IBrandService, BrandService>();
builder.Services.AddSingleton<ILibraryService, LibraryService>();
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
