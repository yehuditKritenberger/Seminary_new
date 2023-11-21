using Microsoft.EntityFrameworkCore;
using Seminary.Model;
using SeminaryProject;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


ConfigurationManager Configuration=builder.Configuration;
builder.Services.AddControllers();
builder.Services.ConfigurationServices();
builder.Services.AddDbContext<SeminaryContext>(option => {
    option.UseSqlServer(Configuration.GetConnectionString("SeminaryConnectionString"));
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

app.UseAuthorization();

app.MapControllers();

app.Run();
