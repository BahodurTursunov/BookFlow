using BookFlow.Infrastructure;
using BookFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace BookFlow.Repository
{
    public class SqlRepository<T>(BookFlowContext context, ILogger logger) : ISqlRepository<T> where T : BaseEntity
    {
        readonly BookFlowContext _context = context;
        readonly ILogger _logger = logger;
        public async Task<T> CreateAsync(T item)
        {
            try
            {
                await _context.AddAsync(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync($"Error + {ex}");
            }
            return item;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var item = await _context.Set<T>().FirstOrDefaultAsync(w => w.Id == id);
                if (item != null)
                {
                    _context.Remove(item);
                    var result = await _context.SaveChangesAsync();
                    return result > 0;
                }
                else
                {
                    await Console.Out.WriteLineAsync($"Item with ID {id} not found");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured while deleting item with ID {id}");
            }
            return false;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(w => w.Id == id);
        }

        public async Task<bool> UpdateAsync(T item)
        {
            try
            {
                _context.Update(item);
                var result = await _context.SaveChangesAsync();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error + {ex}");
            }
            return false;
        }
    }
}
