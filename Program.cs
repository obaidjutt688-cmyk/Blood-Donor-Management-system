using Microsoft.EntityFrameworkCore;
using Blooddonerproj.Data;
using Blooddonerproj.Interface;
using Blooddonerproj.Repositories;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Appdbcontext>(options =>
options.UseSqlite("Data Source=blooddoner.db"));
builder.Services.AddScoped<IDonorRepository, DonorRepository>();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();