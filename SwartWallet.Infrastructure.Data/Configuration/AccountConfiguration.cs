using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWallet.Domain.Models;

namespace SwartWallet.Infrastructure.Data.Configuration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder
                   .HasMany(a => a.MonthlyBudgets)
                   .WithOne(mb=> mb.Account);
                   
        }
    }
}
