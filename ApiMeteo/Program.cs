using ApiMeteo.Models.Business;
using ApiMeteo.Services;
using ApiMeteo.Services.Dal;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<DalService>();
builder.Services.AddTransient<MeteoBL>();


var app = builder.Build();



app.UseSwagger();
app.UseSwaggerUI();

app.UseCors();

app.MapControllers();

app.Run();
