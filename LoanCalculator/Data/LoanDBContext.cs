using LoanCalculator.Interfaces;
using LoanCalculator.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace LoanCalculator.Data
{
    public class LoanDBContext : DbContext
    {
        public LoanDBContext(DbContextOptions<LoanDBContext> options) : base(options)
        {
        }

        public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
