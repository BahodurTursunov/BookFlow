using BookFlow.Repository;
using BookFlow.Services;

namespace SilkRoad.Services;

public static class ServiceCollectionExtensions
{
    public static void AddMyServices(this IServiceCollection service)
    {
        service.AddScoped<ICategoryService, CategoryService>();
        service.AddScoped<IBookService, BookService>();
        service.AddScoped<IAuthorService, AuthorService>();
        service.AddScoped(typeof(ISqlRepository<>), typeof(SqlRepository<>));
    }
}