using Microsoft.EntityFrameworkCore;
using Prpperty_Backend;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var policyName = "_myAllowSpecificOrigins";



// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(opciones =>
                                                opciones.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


//Agregan dependenciass Dbcontext
var Conex = builder.Configuration.GetConnectionString("DefaultConex");
builder.Services.AddDbContext<AppDbcontext>(option => option.UseSqlServer(Conex));

//construye la politica, inidcando que permitira todos lso origenes, todos los metodos y todos los encabezados
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policyName,
                      builder =>
                      {
                          builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                      });
});

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

app.UseCors(policyName);

app.UseAuthorization();

app.MapControllers();

app.Run();
