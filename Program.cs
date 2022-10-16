using FuelQ.Models;
using FuelQ.Services;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<CustomerStoreDatabaseSettings>(
        builder.Configuration.GetSection(nameof(CustomerStoreDatabaseSettings)));
builder.Services.AddSingleton<ICustomerStoreDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<CustomerStoreDatabaseSettings>>().Value);
builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("CustomerStoreDatabaseSettings:ConnectionString")));

builder.Services.AddScoped<ICustomerService, CustomerService>();

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
