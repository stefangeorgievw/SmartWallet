using System.Collections.Generic;

namespace SmartWallet.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }

        public ICollection<MonthlyBudget> MonthlyBudgets { get; set; }
    }
}
