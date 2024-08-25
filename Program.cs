using Microsoft.EntityFrameworkCore;
using sekerbankatm.Core.Repository.Abstract;
using sekerbankatm.Core.Repository.Concrete;
using sekerbankatm.Data;
using sekerbankatm.Service.Abstract;
using sekerbankatm.Service.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<SekerBankAtmDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repository ve Service sınıflarını DI container'a ekleyin
builder.Services.AddScoped<IAtmMachineRepository, AtmMachineRepository>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<IDistrictRepository, DistrictRepository>();

builder.Services.AddScoped<IAtmMachineService, AtmMachineService>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<IDistrictService, DistrictService>();

builder.Services.AddControllers();
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