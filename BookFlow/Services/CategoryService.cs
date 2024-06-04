using BookFlow.Models;
using BookFlow.Repository;

namespace BookFlow.Services
{
    public class CategoryService(ISqlRepository<Category> repository) : ICategoryService
    {
        private ISqlRepository<Category> _repository = repository;

        public async Task<Category?> CreateAsync(Category item)
        {
            if (!string.IsNullOrEmpty(item.Name))
            {
                await _repository.CreateAsync(item);
            }
            return item;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public IQueryable<Category?> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Category?> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(int id, Category item)
        {
            var _item = await _repository.GetByIdAsync(id);
            if (_item is null)
            {
                return false;
            }
            else
            {
                _item.Name = item.Name;
                return await _repository.UpdateAsync(_item);

            }
        }
    }
}
