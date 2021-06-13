using System.ComponentModel.DataAnnotations;

namespace HomeFinance.UI.Model
{
    public class CreateOrUpdateCategoryModel
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)] public int IncomeOrExpenseForBinding { get; set; } = 1;

        public bool IncomeOrExpense
        {
            get => IncomeOrExpenseForBinding > 0;
            set => IncomeOrExpenseForBinding = value ? 1 : -1;
        }
    }
}