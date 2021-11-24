using MediatR;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddCsrsEnvironmentVariables();

builder.AddJwtBearerAuthentication();
builder.UseSerilog();
builder.AddHealthChecks();
builder.AddInstrumentation();
builder.AddRepositories();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddAutoMapper(typeof(Program).Assembly);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
// Prometheus Scraping Endpoint is not currently working, comment out for now
//app.UseOpenTelemetryPrometheusScrapingEndpoint();
app.UseAuthorization();
app.AddHealthChecks();

app.MapControllers();

try
{
    app.Run();
}
finally
{
    // attempt to flush any logs
    Serilog.Log.CloseAndFlush();
}
