using Microsoft.AspNetCore.Identity;
using SmartWallet.Domain.Models;

namespace SwartWallet.Infrastructure.Data.Models
{
    public class ApplicationUser: IdentityUser
    {
        public int? AccountId { get; set; }
        public Account Account { get; set; }
    }
}
