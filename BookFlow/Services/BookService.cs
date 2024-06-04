using BookFlow.Models;
using BookFlow.Repository;

namespace BookFlow.Services
{
    public class BookService(ISqlRepository<Book> repository) : IBookService
    {
        private readonly ISqlRepository<Book> _repository = repository;
        public async Task<Book?> CreateAsync(Book item)
        {
            if (!string.IsNullOrEmpty(item.Title))
            {
                await _repository.CreateAsync(item);
            }
            return item;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public IQueryable<Book> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Book?> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(int id, Book item)
        {
            var _item = await _repository.GetByIdAsync(id);
            if (_item is null)
            {
                return false;
            }
            else
            {
                _item.ISBN = item.ISBN;
                _item.Title = item.Title;
                _item.AuthorId = item.AuthorId;
                _item.Publisher = item.Publisher;
                _item.PublicationDate = item.PublicationDate;
                _item.Genre = item.Genre;
                _item.Description = item.Description;
                _item.Language = item.Language;
                _item.Price = item.Price;
                _item.Pages = item.Pages;
                _item.CoverType = item.CoverType;
                _item.Weight = item.Weight;
                _item.Rating = item.Rating;
                _item.ImageUrl = item.ImageUrl;
                _item.CategoryId = item.CategoryId;

                return await _repository.UpdateAsync(_item);
            }
        }
    }
}
