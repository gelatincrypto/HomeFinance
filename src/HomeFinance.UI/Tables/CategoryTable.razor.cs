using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HomeFinance.UI.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace HomeFinance.UI.Tables
{
    public partial class CategoryTable
    {
        [Parameter]
        public List<CategoryModel> Categories { get; set; }

        [Parameter]
        public EventCallback<long> OnDeleted { get; set; }

        [Inject]
        public IJSRuntime Js { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        string _incomeColor = "#8dc1aa";
        string _expenseColor = "#FF4500";
        private async Task Delete(long id)
        {
            var category = Categories.FirstOrDefault(p => p.Id.Equals(id));

            var confirmed = await Js.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {category.Name} category?");
            if (confirmed)
            {
                await OnDeleted.InvokeAsync(id);
            }
        }

        private void RedirectToUpdate(long id)
        {
            var url = Path.Combine("/updateCategory/", id.ToString());
            NavigationManager.NavigateTo(url);
        }
    }
}
