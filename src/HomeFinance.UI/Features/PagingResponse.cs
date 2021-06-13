using System.Collections.Generic;
using HomeFinance.Services.Business.Pagination;

namespace HomeFinance.UI.Features
{
    public class PagingResponse<T> where T : class
    {
        public List<T> Items { get; set; }
        public MetaData MetaData { get; set; }
    }
}