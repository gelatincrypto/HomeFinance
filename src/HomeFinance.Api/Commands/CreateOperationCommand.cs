using System;
using System.ComponentModel.DataAnnotations;

namespace HomeFinance.Api.Commands
{
    public class CreateOperationCommand
    {
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Amount is required")]
        public long Amount { get; set; }
        [Required(ErrorMessage = "CategoryId is required")]
        public long CategoryId { get; set; }
        [Required(ErrorMessage = "Category is required")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "IncomeOrExpense is required")]
        public bool CategoryIncomeOrExpense { get; set; }
    }
}
