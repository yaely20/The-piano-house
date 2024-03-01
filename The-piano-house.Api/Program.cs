using The_piano_house;
using The_piano_house.Data;
using The_Piano_house.Core;
using The_Piano_house.Core.Repositories;
using The_Piano_house.Core.Services;
using The_Piano_house.Data.Repositories;
using The_Piano_house.Servise;
using Web.Net.API.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<DataContext>();

builder.Services.AddScoped<ICustomersService, CustomersService>();
builder.Services.AddScoped<ICustomersRepository, CustomersRepository>();

builder.Services.AddScoped<IMusicaLInstrumentService, MusicaLInstrumentService>();
builder.Services.AddScoped<IMusicaLInstrumentRepository, MusicaLInstrumentRepository>();

builder.Services.AddScoped<IProviderService, ProviderService>();
builder.Services.AddScoped<IProviderRepository, ProviderRepository>();
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddDbContext<DataContext>();

builder.Services.AddAutoMapper(typeof(MapperProfile));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMiddleware<TrackMiddleware>();

app.MapControllers();

app.Run();
