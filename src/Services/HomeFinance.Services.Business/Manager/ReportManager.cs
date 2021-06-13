using System.Threading.Tasks;
using AutoMapper;
using HomeFinance.Services.Business.DTO;
using HomeFinance.Services.Business.Interfaces;
using HomeFinance.Infrastructure.Data.Interfaces;
using HomeFinance.Infrastructure.Data.Paging;
using HomeFinance.Services.Business.Extensions;

namespace HomeFinance.Services.Business.Manager
{
    public class ReportManager : IReportManager
    {
        private readonly IReportRepository _repository;
        private readonly IMapper _mapper;

        public ReportManager(IReportRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ReportDTO> GetSumAsync(string date)
        {
            var day = date.ToInvariantCultureDate();
            var report = await _repository.GetSumAsync(day);
            return _mapper.Map<ReportDTO>(report);
        }

        public async Task<ReportDTO> GetSumAsync(string startDate, string endDate)
        {
            var startDay = startDate.ToInvariantCultureDate();
            var endDay = endDate.ToInvariantCultureDate();
            var report = await _repository.GetSumAsync(startDay, endDay);
            return _mapper.Map<ReportDTO>(report);
        }

        public async Task<PagedList<OperationDTO>> GetReportAsync(string date, PagingParameters pagingParameters)
        {
            var day = date.ToInvariantCultureDate();
            var report = (await _repository.GetOperationsAsync(day, pagingParameters));
            return _mapper.Map<PagedList<OperationDTO>>(report);
        }

        public async Task<PagedList<OperationDTO>> GetReportAsync(string startDate, string endDate, PagingParameters pagingParameters)
        {
            var startDay = startDate.ToInvariantCultureDate();
            var endDay = endDate.ToInvariantCultureDate();
            var report = (await _repository.GetOperationsAsync(startDay, endDay, pagingParameters));
            return _mapper.Map<PagedList<OperationDTO>>(report);
        }
    }
}
