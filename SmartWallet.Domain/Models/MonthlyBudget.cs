using System;
using System.Collections.Generic;

namespace SmartWallet.Domain.Models
{
    public class MonthlyBudget
    {
        public int Id { get; set; }

        public int AcountId { get; set; }
        public Account Account { get; set; }

        public decimal Income { get; set; }

        public byte Month { get; set; }

        public byte Year { get; set; }

        public DateTime CDate { get; set; }

        public IEnumerable<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
