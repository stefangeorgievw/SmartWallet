using System;

namespace SmartWallet.Domain.Models
{
    public class Expense
    {
        public int Id { get; set; }

        public int BudgetId { get; set; }
        public MonthlyBudget Budget { get; set; }

        public decimal Amount { get; set; }

        public DateTime CDate { get; set; }

        public DateTime AssignedDate { get; set; }

        public int CategoryId { get; set; }
        public ExpenseCategory Category { get; set; }
    }
}
