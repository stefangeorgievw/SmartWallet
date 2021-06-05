using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SwartWallet.Infrastructure.Data.Context
{
    public class SmartWalletDbContext : IdentityDbContext
    {
        public SmartWalletDbContext(DbContextOptions options) : base(options) { }
    }
}
