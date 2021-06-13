using AutoMapper;
using HomeFinance.Infrastructure.Data.Model;
using HomeFinance.Services.Business.DTO;

namespace HomeFinance.Api.MappingProfiles
{
    public class ReportProfile : Profile
    {
        public ReportProfile()
        {
            CreateMap<Report, ReportDTO>().ReverseMap();
        }
    }

}