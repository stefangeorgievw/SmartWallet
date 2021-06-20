using System.Collections.Generic;

namespace SmartWallet.Domain.Models
{
    public class ExpenseCategory
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public ICollection<Expense> Expenses { get; set; } = new HashSet<Expense>();
    }
}
