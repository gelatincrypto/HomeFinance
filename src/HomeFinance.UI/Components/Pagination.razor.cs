using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeFinance.Services.Business.Pagination;
using HomeFinance.UI.Features;
using Microsoft.AspNetCore.Components;

namespace HomeFinance.UI.Components
{
    public partial class Pagination
    {
        [Parameter]
        public MetaData MetaData { get; set; }
        [Parameter]
        public int Spread { get; set; }
        [Parameter]
        public EventCallback<int> SelectedPage { get; set; }

        private List<PagingLink> _links;

        protected override void OnParametersSet()
        {
            CreatePaginationLinks();
        }
        private void CreatePaginationLinks()
        {
            _links = new List<PagingLink> { new (MetaData.CurrentPage - 1, MetaData.HasPrevious, "Previous") };

            var pages = Enumerable.Range(1, MetaData.TotalPages)
                .Where(IsInSpread)
                .Select(pageNumber => new PagingLink
                {
                    Page = pageNumber,
                    Enabled = true,
                    Text = pageNumber.ToString(),
                    Active = MetaData.CurrentPage == pageNumber
                });
            _links.AddRange(pages);


            _links.Add(new PagingLink(MetaData.CurrentPage + 1, MetaData.HasNext, "Next"));
        }

        private bool IsInSpread(int i)
        {
            return i >= MetaData.CurrentPage - Spread && i <= MetaData.CurrentPage + Spread;
        }

        private async Task OnSelectedPage(PagingLink link)
        {
            if (link.Page == MetaData.CurrentPage || !link.Enabled)
                return;
            MetaData.CurrentPage = link.Page;
            await SelectedPage.InvokeAsync(link.Page);
        }
    }
}