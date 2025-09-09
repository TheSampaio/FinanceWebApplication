// Create a builder
var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure routing
builder.Services.Configure<RouteOptions>(options =>
{
    // Force lowercase URLs
    options.LowercaseUrls = true;
});

// Create an app
var app = builder.Build();

// Map endpoints
app.MapControllers();

// In dev mode
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Run the application
app.Run();
