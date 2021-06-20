using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWallet.Domain.Models;

namespace SwartWallet.Infrastructure.Data.Configuration
{
    public class MonthlyBudgetConfiguration : IEntityTypeConfiguration<MonthlyBudget>
    {
        public void Configure(EntityTypeBuilder<MonthlyBudget> builder)
        {
            builder
                .HasMany(mb => mb.Expenses)
                .WithOne(e => e.Budget);
        }
    }
}
