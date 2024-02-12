using DublinBikeMock.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services before building the application
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

// Register your controllers
builder.Services.AddScoped<BikeStationController>();

var app = builder.Build();
app.Run();