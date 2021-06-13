using AutoMapper;
using HomeFinance.Api.Commands;
using HomeFinance.Domain.Core;
using HomeFinance.Infrastructure.Data.Paging;
using HomeFinance.Services.Business.DTO;

namespace HomeFinance.Api.MappingProfiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<CreateCategoryCommand, CategoryDTO>().ReverseMap();
            CreateMap<UpdateCategoryCommand, CategoryDTO>().ReverseMap();
            CreateMap(typeof(PagedList<>), typeof(PagedList<>)).ConvertUsing(typeof(PagedListConverter<,>));
        }
    }
}
