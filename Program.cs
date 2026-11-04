using MiddlewareLogger.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Register controller services
builder.Services.AddControllers();

// Register OpenAPI services
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Custom middleware
app.UseMiddleware<RequestLoggerMiddleware>();

app.UseHttpsRedirection();

// Map controller endpoints
app.MapControllers();

app.Run();