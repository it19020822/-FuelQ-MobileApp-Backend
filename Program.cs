using FuelQ.Models;
using FuelQ.Services;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add customer services to the container.
builder.Services.Configure<CustomerStoreDatabaseSettings>(
        builder.Configuration.GetSection(nameof(CustomerStoreDatabaseSettings)));

builder.Services.AddSingleton<ICustomerStoreDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<CustomerStoreDatabaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("CustomerStoreDatabaseSettings:ConnectionString")));

builder.Services.AddScoped<ICustomerService, CustomerService>();

//--------------------------------------------------------------

// Add owner services to the container.
builder.Services.Configure<OwnerStoreDatabaseSettings>(
        builder.Configuration.GetSection(nameof(OwnerStoreDatabaseSettings)));

builder.Services.AddSingleton<IOwnerStoreDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<OwnerStoreDatabaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("OwnerStoreDatabaseSettings:ConnectionString")));

builder.Services.AddScoped<IOwnerService, OwnerService>();

//--------------------------------------------------------------

// Add fuel services to the container.
builder.Services.Configure<FuelStoreDatabaseSettings>(
    builder.Configuration.GetSection(nameof(FuelStoreDatabaseSettings)));

builder.Services.AddSingleton<IFuelStoreDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<FuelStoreDatabaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("FuelStoreDatabaseSettings:ConnectionString")));

builder.Services.AddScoped<IFuelService, FuelService>();

//--------------------------------------------------------------

// Add feedback services to the container.
builder.Services.Configure<FeedbackStoreDatabaseSettings>(
    builder.Configuration.GetSection(nameof(FeedbackStoreDatabaseSettings)));

builder.Services.AddSingleton<IFeedbackStoreDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<FeedbackStoreDatabaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("FeedbackStoreDatabaseSettings:ConnectionString")));

builder.Services.AddScoped<IFeedbackService, FeedbackService>();

//--------------------------------------------------------------

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
