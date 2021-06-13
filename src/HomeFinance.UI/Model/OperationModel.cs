using System;
using System.ComponentModel.DataAnnotations;
using HomeFinance.UI.Attribute;

namespace HomeFinance.UI.Model
{
    public class OperationModel
    {
        public long Id { get; set; }
        [Required]
        [FromDateToNow(DateFrom ="01-01-2020", ErrorMessage = "Date can't be early than {1} and later than today")]
        public DateTime Date { get; set; }
        [Required]
        [Range(1, long.MaxValue, ErrorMessage = "Value for the Amount can't be lower than 1")]
        public long Amount { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Choose category")]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryIncomeOrExpense { get; set; }
    }
}