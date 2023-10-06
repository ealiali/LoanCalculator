using LoanCalculator.Classes;
using LoanCalculator.Data;
using LoanCalculator.Interfaces;
using LoanCalculator.Repositories;
using LoanCalculator.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<LoanDBContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("LoanDBConnectionString")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(ILoanRepository), typeof(LoanRepository));
builder.Services.AddScoped(typeof(ILoanService), typeof(LoanService));
builder.Services.AddScoped(typeof(ICarLoan), typeof(CarLoan));
builder.Services.AddScoped(typeof(IPersonalLoan), typeof(PersonalLoan));
builder.Services.AddScoped(typeof(IInvestmentLoan), typeof(InvestmentLoan));

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
