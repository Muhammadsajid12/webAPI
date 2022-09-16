using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SuperHeroAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Here i inject the builder for swagger and also tell where to get the table from(ContactAPIdbContext.cs)
//builder.Services.AddDbContext<ContactsAPIdbContext>(options => options.UseInMemoryDatabase("ContactsDb"));

builder.Services.AddDbContext<ContactsAPIdbContext>(options => options.UseSqlServer( builder.Configuration.GetConnectionString("ContactsApiconnectionstring")));

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
