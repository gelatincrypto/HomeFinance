using System.Threading.Tasks;
using AutoMapper;
using HomeFinance.Domain.Core;
using HomeFinance.Services.Business.DTO;
using HomeFinance.Services.Business.Interfaces;
using HomeFinance.Infrastructure.Data.Interfaces;
using HomeFinance.Infrastructure.Data.Paging;

namespace HomeFinance.Services.Business.Manager
{
    public class OperationManager : IOperationManager
    {
        private readonly IOperationRepository _repository;
        private readonly IMapper _mapper;

        public OperationManager(IOperationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PagedList<OperationDTO>> GetAllAsync(PagingParameters pagingParameters)
        {
            return _mapper.Map<PagedList<OperationDTO>>(await _repository.GetAllAsync(pagingParameters));
        }

        public async Task<OperationDTO> GetAsync(long id)
        {
            return _mapper.Map<OperationDTO>(await _repository.GetAsync(id));
        }

        public async Task CreateAsync(OperationDTO item)
        {
            Operation model = _mapper.Map<Operation>(item);
            await _repository.CreateAsync(model);
        }

        public async Task<bool> UpdateAsync(long id, OperationDTO item)
        {
            if (!await _repository.ExistAsync(operation => operation.Id == id))
                return false;

            var newOperation = _mapper.Map<Operation>(item);
            await _repository.UpdateAsync(newOperation);
            return true;
        }

        public async Task DeleteAsync(long id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
