using System.ComponentModel.DataAnnotations;

namespace HomeFinance.UI.Model
{
    public class CategoryModel
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required] 
        public bool IncomeOrExpense { get; set; }
    }
}