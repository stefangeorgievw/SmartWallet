using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWallet.Domain.Models;

namespace SwartWallet.Infrastructure.Data.Configuration
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder
                .HasOne(e => e.Category)
                .WithMany(c => c.Expenses);
        }
    }
}
