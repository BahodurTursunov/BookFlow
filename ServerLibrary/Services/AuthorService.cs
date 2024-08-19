using BookFlow.Models;
using BookFlow.Repository;

namespace BookFlow.Services
{
    public class AuthorService(ISqlRepository<Author> repository) : IAuthorService
    {
        private ISqlRepository<Author> _repository = repository;

        public async Task<Author> Create(Author item)
        {
            if (!string.IsNullOrEmpty(item.Name))
            {
                await _repository.CreateAsync(item);
            }
            return item;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public IQueryable<Author> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Author> GetById(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public async Task<bool> Update(int id, Author item)
        {
            var _item = await _repository.GetByIdAsync(id);
            if (_item is null)
            {
                return false;
            }
            else
            {
                _item.Name = item.Name;
                _item.Biography = item.Biography;
                return await _repository.UpdateAsync(_item);
            }
        }
    }
}
