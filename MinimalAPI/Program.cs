using Microsoft.EntityFrameworkCore;
using MinimalAPI.Endpoints;
using MinimalAPI.Models.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<CRMContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("connectionString"));
});

builder.Services.AddScoped<CustomerDAL>();

var app = builder.Build();

app.AddCustomerEndpoints();

app.UseHttpsRedirection();

app.Run();
