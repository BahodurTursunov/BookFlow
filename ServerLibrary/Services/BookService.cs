using BookFlow.Models;
using BookFlow.Repository;

namespace BookFlow.Services
{
    public class BookService(ISqlRepository<Book> repository/*, IBookAuthorService<BookAuthor> bookAuthorService*/) : IBookService
    {
        readonly ISqlRepository<Book> _repository = repository;
        //readonly IBookAuthorService<BookAuthor> _bookAuthorService = bookAuthorService;
        public async Task<Book> Create(Book item)
        {
            if (!string.IsNullOrEmpty(item.Title))
            {
                await _repository.CreateAsync(item);
            }
            return item;
        }
        public async Task<Book> Create(Book item, Author item2)
        {
            if (!string.IsNullOrEmpty(item.Title))
            {

                var book = await _repository.CreateAsync(item);
                //var author = await _bookAuthorService.CreateAsync(ICollection<Book> item, ICollection<Author> item2);

                //await _bookAuthorService.CreateAsync(book.Id, author.Id);
                return book;
            }
            return item;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public IQueryable<Book> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Book> GetById(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public async Task<bool> Update(int id, Book item)
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
                _item.Genre = item.Genre;
                _item.Description = item.Description;
                _item.Price = item.Price;
                _item.ImageUrl = item.ImageUrl;

                return await _repository.UpdateAsync(_item);
            }
        }
    }
}
