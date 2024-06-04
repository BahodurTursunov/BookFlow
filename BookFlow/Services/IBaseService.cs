namespace BookFlow.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        IQueryable<TEntity?> GetAll();
        Task<TEntity?> GetByIdAsync(int id);
        Task<TEntity?> CreateAsync(TEntity item);
        Task<bool> UpdateAsync(int id, TEntity item);
        Task<bool> DeleteAsync(int id);

    }
}
