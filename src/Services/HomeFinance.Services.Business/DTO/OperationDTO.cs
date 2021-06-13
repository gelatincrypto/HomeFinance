using System;

namespace HomeFinance.Services.Business.DTO
{
    public class OperationDTO
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long Amount { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryIncomeOrExpense { get; set; }
    }
}
