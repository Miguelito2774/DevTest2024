using api.Application.Repositories;
using api.Infrastructure.Lists;
using api.Infrastructure.Persistent;
using api.Infrastructure.Repositories.Dbs;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy => { policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); }
    );
});

builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseNpgsql(connectionString));

builder.Services.AddControllers();
//builder.Services.AddSingleton<IPollRepository, PollListRepository>();
//builder.Services.AddSingleton<IOptionRepository, OptionListRepository>();
builder.Services.AddScoped<IPollRepository, PollDbRepository>();
builder.Services.AddScoped<IOptionRepository, OptionDbRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseCors();
app.MapControllers();
app.Run();

