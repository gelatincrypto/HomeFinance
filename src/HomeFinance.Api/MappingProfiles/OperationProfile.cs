using AutoMapper;
using HomeFinance.Api.Commands;
using HomeFinance.Domain.Core;
using HomeFinance.Services.Business.DTO;

namespace HomeFinance.Api.MappingProfiles
{
    public class OperationProfile : Profile
    {
        public OperationProfile()
        {
            CreateMap<OperationDTO, Operation>()
                .ForMember(m => m.Category,
                    o => o.MapFrom(m =>
                        new Category
                        {
                            Id = m.CategoryId,
                            IncomeOrExpense = m.CategoryIncomeOrExpense,
                            Name = m.CategoryName
                        }))
                .ReverseMap();
            CreateMap<Category, OperationDTO>().ReverseMap();
            CreateMap<CreateOperationCommand, OperationDTO>().ReverseMap();
            CreateMap<UpdateOperationCommand, OperationDTO>().ReverseMap();
        }
    }
}
