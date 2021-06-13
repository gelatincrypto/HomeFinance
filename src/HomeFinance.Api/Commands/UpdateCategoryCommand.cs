using System.ComponentModel.DataAnnotations;

namespace HomeFinance.Api.Commands
{
    public class UpdateCategoryCommand
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "IncomeOrExpense is required")]
        public bool IncomeOrExpense { get; set; }
    }
}
