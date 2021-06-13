using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HomeFinance.Domain.Core;
using HomeFinance.Services.Business.DTO;
using HomeFinance.Services.Business.Exceptions;
using HomeFinance.Services.Business.Interfaces;
using HomeFinance.Infrastructure.Data.Interfaces;

namespace HomeFinance.Services.Business.Manager
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllAsync()
        {
            var categories = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categories);
        }

        public async Task<CategoryDTO> GetAsync(long id)
        {
            return _mapper.Map<CategoryDTO>(await _repository.GetAsync(id));
        }

        public async Task<bool> CreateAsync(CategoryDTO item)
        {
            if (await _repository.ExistAsync(category => category.Name == item.Name))
                return false;
            Category model = _mapper.Map<Category>(item);
            await _repository.CreateAsync(model);
            return true;
        }

        public async Task UpdateAsync(long id, CategoryDTO item)
        {
            if (!await _repository.ExistAsync(category => category.Id == id))
                throw new CategoryNotFoundException($"Category with id={id} not exist.");

            if (await _repository.ExistAsync(category => id!= category.Id && category.Name == item.Name))
                throw new CategoryAlreadyExistException($"Category with name={item.Name} already exist.");

            var newOperation = _mapper.Map<Category>(item);
            await _repository.UpdateAsync(newOperation);
        }

        public async Task DeleteAsync(long id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
