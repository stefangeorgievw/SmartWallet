using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartWallet.Domain.Models;
using SwartWallet.Infrastructure.Data.Models;
using System.Reflection;

namespace SwartWallet.Infrastructure.Data.Context
{
    public class SmartWalletDbContext : IdentityDbContext<ApplicationUser>
    {
        public SmartWalletDbContext(DbContextOptions<SmartWalletDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<MonthlyBudget> MonthlyBudgets { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
