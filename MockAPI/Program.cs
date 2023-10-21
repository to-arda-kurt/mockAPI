using Microsoft.EntityFrameworkCore;
using MockAPI.Configurations;
using MockAPI.Data;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration.GetConnectionString("MockAPIConnectionString");
builder.Services.AddDbContext<MockApiDbContext>(options => 
    options.UseSqlServer(connection));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{options.AddPolicy("AllowAll", 
    b => b
        .AllowAnyHeader()
        .AllowAnyOrigin()
        .AllowAnyMethod());
    
});

// SeriLog Configuration
builder.Host.UseSerilog((ctx, lc) => 
    lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));

//AutoMapper Injections
builder.Services.AddAutoMapper(typeof(MapperConfig));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();