using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwartWallet.Infrastructure.Data.Models;

namespace SwartWallet.Infrastructure.Data
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
             builder
                   .HasOne(u => u.Account)
                   .WithOne()
                   .HasForeignKey<ApplicationUser>(ap => ap.AccountId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
