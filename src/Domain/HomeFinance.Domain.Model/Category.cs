using System.Collections.Generic;

namespace HomeFinance.Domain.Core
{
    public class Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IncomeOrExpense { get; set; } // true Income, false Expense
        public virtual List<Operation> Operations { get; set; }
    }
}
