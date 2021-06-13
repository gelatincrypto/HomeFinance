using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using HomeFinance.Infrastructure.Data.Paging;

namespace HomeFinance.Api.MappingProfiles
{
    public class PagedListConverter<TSource, TDestination> : ITypeConverter<PagedList<TSource>, PagedList<TDestination>> where TSource : class where TDestination : class
    {
        public PagedList<TDestination> Convert(PagedList<TSource> source, PagedList<TDestination> destination, ResolutionContext context)
        {
            var collection = context.Mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(source).ToList();

            return new PagedList<TDestination>(collection, source.TotalCount, source.CurrentPage, source.PageSize);
        }
    }
}