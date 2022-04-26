using Microsoft.EntityFrameworkCore;
using repository_pattern_project.Models.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//here is the changes

builder.Services.AddDbContext<PrescriptionDataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});




builder.Services.AddControllers();
//registering the dependency injection
builder.Services.AddScoped<IPrescriptionRepository, PrescriptionRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
