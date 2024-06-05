namespace BookFlow.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);

        Task<TEntity> Create(TEntity item);

        Task<bool> Update(int id, TEntity item);

        Task<bool> Delete(int id);

    }
}
